using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALIGN_TEST
{
    public partial class Motion_Form : Form
    {
        public int m_lAxisCounts = 0;                         // 제어 가능한 축갯수 선언 및 초기화
        private int m_lAxisNo = 0;                             // 제어할 축 번호 선언 및 초기화
        public uint m_uModuleID = 0;                           // 제어할 축의 모듈 I/O 선언 및 초기화 
        public uint m_lMoveMultiAxesCount = 0;                 // 다축구동할 축 갯수 선언 및 초기화    
        public int[] m_lMoveMultiAxes = { -1, -1, -1, -1 };     // 다축구동할 축 배열 갯수 선언 및 초기화
        public int m_lBoardNo = 0, m_lModulePos = 0;

        public double[] m_dOldCmdPos = { 0.0, 0.0, 0.0, 0.0 };   // tmDisplay에서 사용할 이전 Command Position	
        public double[] m_dOldActPos = { 0.0, 0.0, 0.0, 0.0 };   // tmDisplay에서 사용할 이전 Actual Position
        public double[] m_dOldCmdVel = { 0.0, 0.0, 0.0, 0.0 };   // tmDisplay에서 사용할 이전 Command Velocity

        private short ParseHexShort(string hexStr)
        {
            hexStr = hexStr.Trim();
            if (hexStr.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                hexStr = hexStr.Substring(2);
            }
            return Convert.ToInt16(hexStr, 16);
        }

        public Motion_Form()
        {
            InitializeComponent();
        }

        public void UpdateState()
        {
            CheckBox[] chkMoveMultiAxes = { chkAxis00, chkAxis01, chkAxis02, chkAxis03 };

            uint duOnOff = 0;

            for (uint lCount = 0; lCount < m_lMoveMultiAxesCount; lCount++)
            {
                //++ 지정한 축의 서보온 상태를 반환합니다.
                //CAXM.AxmSignalIsServoOn(m_lMoveMultiAxes[lCount], ref duOnOff);
                duOnOff = (uint)mc2xxstd.SscApi.sscCheckServoOn(0, 1, m_lAxisNo);
                mc2xxstd.SscApi.sscServoOn(0, 1, m_lAxisNo);
                // 선택된 보간축들이 모두 서보온 되어있을 때 TRUE 
            }
        }

        public void Servo_On()
        {
            // X=0, Y=1, T=2 각 축을 개별적으로 ServoOn
            for (int lCount = 0; lCount < 3; lCount++)
            {
                mc2xxstd.SscApi.sscServoOn(0, 1, lCount);
            }

            chkAxis00.Checked = true;
            chkAxis01.Checked = true;
            chkAxis02.Checked = true;

            Check_Status();
            UpdateState();

            for (int lCount = 0; lCount < 3; lCount++)
            {
                //++ 지정 축의 Servo On/Off 신호를 출력합니다.
                mc2xxstd.SscApi.sscServoOn(0, 1, lCount);
                mc2xxstd.SscApi.sscCheckServoOn(0, 1, lCount);
            }
        }

        public void Servo_Move(double[] dPos, double dVel, double dAcc, double dDec)
        {
            double dXY_Distance = 0.42;//1당 픽셀 이동 X Resolution
            //double dT_Distance = 0.0236;
            double dT_Distance = 0.072;
            double dX_Offset = (dPos[2] / dT_Distance) * 0.048;
            TextBox[] DisplayCmdPos = new TextBox[4];
            DisplayCmdPos[0] = edtCmdPos00; DisplayCmdPos[1] = edtCmdPos01; DisplayCmdPos[2] = edtCmdPos02; DisplayCmdPos[3] = edtCmdPos03;

            double dx, dy, dt;
            dx = Convert.ToDouble(DisplayCmdPos[0].Text) + ((dPos[0]/*+dX_Offset*/) / dXY_Distance);
            dy = Convert.ToDouble(DisplayCmdPos[1].Text) + ((dPos[1] / dXY_Distance) * -1);
            dt = Convert.ToDouble(DisplayCmdPos[2].Text) + (dPos[2] / dT_Distance);

            double[] dMultiPos = { dx, dy, dt, 0.0 }, dMultiVel = { dVel, dVel, dVel, 0.0 },
                                 dMultiAcc = { dAcc, dAcc, dAcc, 0.0 }, dMultiDec = { dDec, dDec, dDec, 0.0 };

            // 각 축 번호를 0(X), 1(Y), 2(T)로 개별 지정하여 인크리멘탈 이동
            mc2xxstd.SscApi.sscIncStart(0, 1, 0, int.Parse(dx.ToString()), (int)dVel, (short)dAcc, (short)dDec);//인크리멘탈 이동X
            mc2xxstd.SscApi.sscIncStart(0, 1, 1, int.Parse(dy.ToString()), (int)dVel, (short)dAcc, (short)dDec);//인크리멘탈 이동Y
            mc2xxstd.SscApi.sscIncStart(0, 1, 2, int.Parse(dt.ToString()), (int)dVel, (short)dAcc, (short)dDec);//인크리멘탈 이동T
        }

        public void Check_Status()
        {
            TextBox[] DisplayCmdPos = new TextBox[4];
            DisplayCmdPos[0] = edtCmdPos00; DisplayCmdPos[1] = edtCmdPos01; DisplayCmdPos[2] = edtCmdPos02; DisplayCmdPos[3] = edtCmdPos03;
            TextBox[] DisplayActPos = new TextBox[4];
            DisplayActPos[0] = edtActPos00; DisplayActPos[1] = edtActPos01; DisplayActPos[2] = edtActPos02; DisplayActPos[3] = edtActPos03;
            TextBox[] DisplayCmdVel = new TextBox[4];
            DisplayCmdVel[0] = edtCmdVel00; DisplayCmdVel[1] = edtCmdVel01; DisplayCmdVel[2] = edtCmdVel02; DisplayCmdVel[3] = edtCmdVel03;

            CheckBox[] chkMoveMultiAxes = new CheckBox[4];
            chkMoveMultiAxes[0] = chkAxis00; chkMoveMultiAxes[1] = chkAxis01;
            chkMoveMultiAxes[2] = chkAxis02; chkMoveMultiAxes[3] = chkAxis03;

            uint lCount, lArrayIndex = 0;
            double dCmdPos = 0.0;
            double dActPos = 0.0;
            double dCmdVel = 0.0;

            for (lCount = 0; lCount < 4; lCount++)
            {
                if (chkMoveMultiAxes[lCount].Checked)
                {
                    int currentAxis = (int)lCount; // 루프 인덱스를 축 번호로 사용

                    //++ 지정한 축의 지령(Command)위치를 반환합니다.
                    mc2xxstd.SscApi.sscGetCurrentCmdPositionFast(0, 1, currentAxis, out int CMDposition);
                    dCmdPos = (double)CMDposition;
                    if (m_dOldCmdPos[lCount] != dCmdPos)
                    {
                        DisplayCmdPos[lCount].Text = String.Format("{0:0.000}", dCmdPos);
                        m_dOldCmdPos[lCount] = dCmdPos;
                    }
                    //++ 지정한 축의 실제(Feedback)위치를 반환합니다.
                    mc2xxstd.SscApi.sscGetCurrentFbPositionFast(0, 1, currentAxis, out int FBposition);
                    dActPos = (double)FBposition;
                    if (m_dOldActPos[lCount] != dActPos)
                    {
                        DisplayActPos[lCount].Text = String.Format("{0:0.000}", dActPos);
                        m_dOldActPos[lCount] = dActPos;
                    }
                    //++ 지정한 축의 구동 속도를 반환합니다.
                    mc2xxstd.SscApi.sscGetCmdSpeedFast(0, 1, currentAxis, out int Vel);
                    dCmdVel = (double)Vel;
                    if (m_dOldCmdVel[lCount] != dCmdVel)
                    {
                        DisplayCmdVel[lCount].Text = String.Format("{0:0.000}", dCmdVel);
                        m_dOldCmdVel[lCount] = dCmdVel;
                    }
                    ++lArrayIndex;
                }
            }
        }

        #region [구분]: Control에 이벤트가 발생했을 때 처리하는 함수들 모음 

        // ++ =======================================================================
        // >> Project Name_Load(...) : 프로젝트 Form 초기화 함수.
        //  - Form을 Load시 불러내는 함수, 초기화에 사용합니다.
        // --------------------------------------------------------------------------
        private void MoveMultiAxes_Load(object sender, EventArgs e)
        {

        }

        // ++ =======================================================================
        // >> tmDisplay_Tick(...) : 타이머 이벤트 핸들러 함수.
        //  - 일정한 주기로 변경되는 위치/속도/정보등을 Control에 반영합니다.
        // --------------------------------------------------------------------------
        private void tmDisplay_Tick(object sender, EventArgs e)
        {
            TextBox[] DisplayCmdPos = { edtCmdPos00, edtCmdPos01, edtCmdPos02, edtCmdPos03 };
            TextBox[] DisplayActPos = { edtActPos00, edtActPos01, edtActPos02, edtActPos03 };
            TextBox[] DisplayCmdVel = { edtCmdVel00, edtCmdVel01, edtCmdVel02, edtCmdVel03 };
            CheckBox[] chkMoveMultiAxes = { chkAxis00, chkAxis01, chkAxis02, chkAxis03 };

            for (int lCount = 0; lCount < 4; lCount++)
            {
                if (chkMoveMultiAxes[lCount].Checked)
                {
                    // [제가 수정한 정보입니다] 배열의 인덱스(lCount)를 제어할 축 번호로 가정하여 파라미터로 전달
                    int currentAxis = lCount;

                    // [제가 수정한 정보입니다] 반환값이 아닌 out 변수에 실제 데이터가 담긴다고 추론하여 CMDposition 활용
                    mc2xxstd.SscApi.sscGetCurrentCmdPositionFast(0, 1, currentAxis, out int CMDposition);
                    double dCmdPos = (double)CMDposition;
                    if (m_dOldCmdPos[lCount] != dCmdPos)
                    {
                        DisplayCmdPos[lCount].Text = String.Format("{0:0.000}", dCmdPos);
                        m_dOldCmdPos[lCount] = dCmdPos;
                    }

                    mc2xxstd.SscApi.sscGetCurrentFbPositionFast(0, 1, currentAxis, out int FBposition);
                    double dActPos = (double)FBposition;
                    if (m_dOldActPos[lCount] != dActPos)
                    {
                        DisplayActPos[lCount].Text = String.Format("{0:0.000}", dActPos);
                        m_dOldActPos[lCount] = dActPos;
                    }

                    mc2xxstd.SscApi.sscGetCmdSpeedFast(0, 1, currentAxis, out int speed);
                    double dCmdVel = (double)speed;
                    if (m_dOldCmdVel[lCount] != dCmdVel)
                    {
                        DisplayCmdVel[lCount].Text = String.Format("{0:0.000}", dCmdVel);
                        m_dOldCmdVel[lCount] = dCmdVel;
                    }
                }
            }
        }

        // ++ =======================================================================
        // >> cboSelAxis_SelectedIndexChanged() : 축 번호 변경시 호출되는 핸들러 함수.
        //  - 축 번호가 변경되었을 때 변경된 축의 모듈 ID와 Control들을 갱신합니다.
        // -------------------------------------------------------------------------
        private void cboSelAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_lAxisNo = cboSelAxis.SelectedIndex;
            //++ 지정한 축번호의 모듈ID를 반환합니다.
            // [INFO] 여러개의 정보를 읽는 함수 사용시 불필요한 정보는 NULL(0)을 입력하면 됩니다.
            UpdateState();      // 변경한 축의 상태와 Control들의 상태를 일치시킵니다.
        }
        // ++ =======================================================================
        // >> btnLoadFile_Click() : "Load File"버튼 클릭시 호출되는 핸들러 함수.
        //  - 임의 위치에 있는 Mot(AXM에서 사용하는 설정파일 형식) 파일을 불러옵니다.
        //  - 이 함수를 통해 임의의 Mot파일을 불러오면 모션축의 설정값들이 Mot파일의 
        //    설정값들로 일괄 변경됩니다.
        // --------------------------------------------------------------------------
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "AXM files (*.mot)|*.mot|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            char[] nFilename = new char[255];
            string temp = null;

            //++ 함수 실행 성공시 지정한 Mot파일의 설정값으로 모션축 설정이 일괄 변경됩니다.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                temp = openFileDialog1.FileName;
            }
            else
            {
                UpdateState();      // 변경된 모션축의 상태와 Control들의 상태를 일치시킵니다.
            }
        }


        // ++ =========================================================================
        // >> chkAxis_Click(...) : 보간축 변경이 있을 때 호출되는 핸들러 함수. 
        //  - 축 번호 선택 체크버튼의 체크상태에 변화가 있을 때 보간 사용축 갯수 및 축
        //    번호 배열값을 재할당합니다.
        //  - chkAxis00 ~ chkAxis03 버튼의 클릭이벤트 발생시 호출됩니다.
        // ----------------------------------------------------------------------------
        private void chkAxis_Click(object sender, EventArgs e)
        {
            UpdateState();
        }
        // ++ =======================================================================
        // >> btnPosClear_Click() : "Clear"버튼 클릭시 호출되는 핸들러 함수.
        //  - 선택된 보간축들의 위치정보를 0.0으로 설정합니다.
        //  - AxmStatusSetPosMatch함수는 AxmStatusSetCmdPos, AxmStatusSetActPos 함수를 
        //    사용하는것과 동일한 효과를 냅니다.
        // --------------------------------------------------------------------------
        private void btnPosClear_Click(object sender, EventArgs e)
        {
            //for (lCount = 0; lCount < m_lMoveMultiAxesCount; lCount++)
            //CAXM.AxmStatusSetCmdPos(m_lMoveIntpAxes[lCount], 0);
            //CAXM.AxmStatusSetActPos(m_lMoveIntpAxes[lCount], 0);
            //++ Command위치와 Actual위치를 입력한 값으로 설정합니다.
            //CAXM.AxmStatusSetPosMatch(m_lMoveMultiAxes[lCount], 0.0);
        }
        // ++ =======================================================================
        // >> btnPosMove_Click() : "Move"버튼 클릭시 호출되는 핸들러 함수.
        //  - 선택한 축들을 지정한 거리(또는 위치)/속도/가속도/감속도로 모션구동합니다.
        // --------------------------------------------------------------------------
        private void btnPosMove_Click(object sender, EventArgs e)
        {
            TextBox[] MovePos = new TextBox[4];
            MovePos[0] = edtMovePos00; MovePos[1] = edtMovePos01; MovePos[2] = edtMovePos02; MovePos[3] = edtMovePos03;
            TextBox[] MoveVel = new TextBox[4];
            MoveVel[0] = edtMoveVel00; MoveVel[1] = edtMoveVel01; MoveVel[2] = edtMoveVel02; MoveVel[3] = edtMoveVel03;
            TextBox[] MoveAcc = new TextBox[4];
            MoveAcc[0] = edtMoveAcc00; MoveAcc[1] = edtMoveAcc01; MoveAcc[2] = edtMoveAcc02; MoveAcc[3] = edtMoveAcc03;
            TextBox[] MoveDec = new TextBox[4];
            MoveDec[0] = edtMoveDec00; MoveDec[1] = edtMoveDec01; MoveDec[2] = edtMoveDec02; MoveDec[3] = edtMoveDec03;
            CheckBox[] chkMoveMultiAxes = new CheckBox[4];
            chkMoveMultiAxes[0] = chkAxis00; chkMoveMultiAxes[1] = chkAxis01;
            chkMoveMultiAxes[2] = chkAxis02; chkMoveMultiAxes[3] = chkAxis03;

            uint lCount, lArrayIndex;
            double[] dMultiPos = { 0.0, 0.0, 0.0, 0.0 }, dMultiVel = { 0.0, 0.0, 0.0, 0.0 },
                     dMultiAcc = { 0.0, 0.0, 0.0, 0.0, }, dMultiDec = { 0.0, 0.0, 0.0, 0.0 };

            lArrayIndex = 0;

            for (lCount = 0; lCount < 4; lCount++)
            {
                if (chkMoveMultiAxes[lCount].Checked)
                {
                    dMultiPos[lArrayIndex] = Convert.ToDouble(MovePos[lCount].Text);
                    dMultiVel[lArrayIndex] = Convert.ToDouble(MoveVel[lCount].Text);
                    dMultiAcc[lArrayIndex] = Convert.ToDouble(MoveAcc[lCount].Text);
                    dMultiDec[lArrayIndex] = Convert.ToDouble(MoveDec[lCount].Text);
                    ++lArrayIndex;
                }
            }
            if (chkMoveBlock.Checked)
            {
                //++ 지정한 축들을 지정한 거리(또는 위치)/속도/가속도/감속도로 각각 모션구동하고 모션이 종료되면 함수를 빠져나옵니다.
                //duRetCode = CAXM.AxmMoveMultiPos((int)m_lMoveMultiAxesCount, m_lMoveMultiAxes, dMultiPos, dMultiVel, dMultiAcc, dMultiDec);
                mc2xxstd.SscApi.sscIncStart(0, 1, m_lAxisNo,
                    (int)double.Parse(MovePos[m_lAxisNo].Text.ToString()), // 이동 거리(위치)
                    (int)double.Parse(MoveVel[m_lAxisNo].Text.ToString()), // 속도
                    (short)double.Parse(MoveAcc[m_lAxisNo].Text.ToString()),
                    (short)double.Parse(MoveDec[m_lAxisNo].Text.ToString()));
            }
            else
            {
                //++ 지정한 축들을 지정한 거리(또는 위치)/속도/가속도/감속도로 각각 모션구동하고 모션 종료여부와 상관없이 함수를 빠져나옵니다.
                //duRetCode = CAXM.AxmMoveStartMultiPos((int)m_lMoveMultiAxesCount, m_lMoveMultiAxes, dMultiPos, dMultiVel, dMultiAcc, dMultiDec);
                mc2xxstd.SscApi.sscIncStart(0, 1, m_lAxisNo,
                    (int)double.Parse(MovePos[m_lAxisNo].Text.ToString()), // 이동 거리(위치)
                    (int)double.Parse(MoveVel[m_lAxisNo].Text.ToString()), // 속도
                    (short)double.Parse(MoveAcc[m_lAxisNo].Text.ToString()),
                    (short)double.Parse(MoveDec[m_lAxisNo].Text.ToString()));
            }
        }

        // ++ =======================================================================
        // >> btnPosStop_Click() : "Stop"버튼 클릭시 호출되는 핸들러 함수.
        //  - 선택한 축들로 구동정지 함수를 호출하여 구동을 종료합니다.
        // ※ [CAUTION] 다축 구동함수들로 구동시 포함된 축중 한축만 정지해도 다른축들이 
        //    구동을 정지하게 됩니다.
        // --------------------------------------------------------------------------
        private void btnPosStop_Click(object sender, EventArgs e)
        {
            //for (lCount = 0; lCount < m_lMoveMultiAxesCount; lCount++)
            //++ 지정한 축의 구동을 감속정지합니다.
            //CAXM.AxmMoveSStop(m_lMoveMultiAxes[lCount]);
            mc2xxstd.SscApi.sscChangeManualDecTime(0, 1, m_lAxisNo, 0);
        }

        // ++ =======================================================================
        // >> btnJogMoveP_MouseDown(...) : "Move Jog(+/-)"버튼 Down시 호출되는 핸들러 함수.
        //  - 버튼 이벤트인 MouseDown 함수를 이용하여 조그 버튼을 구현 합니다.
        //  - Jog버튼 Down시 연속구동 함수를 호출하여 Jog 구동을 시작합니다.
        // --------------------------------------------------------------------------
        private void btnJogP_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox[] JogVel = new TextBox[4];
            JogVel[0] = edtJogVel00; JogVel[1] = edtJogVel01; JogVel[2] = edtJogVel02; JogVel[3] = edtJogVel03;
            TextBox[] JogAcc = new TextBox[4];
            JogAcc[0] = edtJogAcc00; JogAcc[1] = edtJogAcc01; JogAcc[2] = edtJogAcc02; JogAcc[3] = edtJogAcc03;
            TextBox[] JogDec = new TextBox[4];
            JogDec[0] = edtJogDec00; JogDec[1] = edtJogDec01; JogDec[2] = edtJogDec02; JogDec[3] = edtJogDec03;
            CheckBox[] chkMoveMultiAxes = new CheckBox[4];
            chkMoveMultiAxes[0] = chkAxis00; chkMoveMultiAxes[1] = chkAxis01;
            chkMoveMultiAxes[2] = chkAxis02; chkMoveMultiAxes[3] = chkAxis03;

            uint lCount, lArrayIndex;
            double[] dMultiJogVel = { 0.0, 0.0, 0.0, 0.0 }, dMultiJogAcc = { 0.0, 0.0, 0.0, 0.0, }, dMultiJogDec = { 0.0, 0.0, 0.0, 0.0 };

            lArrayIndex = 0;

            for (lCount = 0; lCount < 4; lCount++)
            {
                if (chkMoveMultiAxes[lCount].Checked)
                {
                    dMultiJogVel[lArrayIndex] = Convert.ToDouble(JogVel[lCount].Text);
                    dMultiJogAcc[lArrayIndex] = Convert.ToDouble(JogAcc[lCount].Text);
                    dMultiJogDec[lArrayIndex] = Convert.ToDouble(JogDec[lCount].Text);
                    ++lArrayIndex;
                }
            }
            //++ 지정한 축을 (+)방향으로 지정한 속도/가속도/감속도로 모션구동합니다.
            //duRetCode = CAXM.AxmMoveStartMultiVel((int)m_lMoveMultiAxesCount, m_lMoveMultiAxes, dMultiJogVel, dMultiJogAcc, dMultiJogDec);
            mc2xxstd.SscApi.sscJogStart(0, 1, m_lAxisNo, (int)double.Parse(JogVel[m_lAxisNo].Text.ToString()), (short)double.Parse(JogAcc[m_lAxisNo].Text.ToString()), (short)double.Parse(JogDec[m_lAxisNo].Text.ToString()), mc2xxstd.SscApi.SSC_DIR_PLUS);
        }

        // ++ =======================================================================
        // >> btnJogMoveP_MouseUp(...) : "Move Jog(+/-)"버튼 Up시 호출되는 핸들러 함수.
        //  - 버튼 이벤트인 MouseUp 함수를 이용하여 조그 버튼을 구현 합니다.
        //  - Jog버튼 Up시 구동정지 함수를 호출하여 Jog 구동을 종료합니다.
        // --------------------------------------------------------------------------
        private void btnJogP_MouseUp(object sender, MouseEventArgs e)
        {
            //for (lCount = 0; lCount < m_lMoveMultiAxesCount; lCount++)
            //++ 지정한 축의 Jog구동(모션구동)을 종료합니다.  
            //CAXM.AxmMoveSStop(m_lMoveMultiAxes[lCount]);

            mc2xxstd.SscApi.sscJogStop(0, 1, m_lAxisNo);
        }

        // ++ =======================================================================
        // >> btnJogN_MouseDown(...) : "Move Jog(+/-)"버튼 Down시 호출되는 핸들러 함수.
        //  - 버튼 이벤트인 MouseDown 함수를 이용하여 조그 버튼을 구현 합니다.
        //  - Jog버튼 Down시 연속구동 함수를 호출하여 Jog 구동을 시작합니다.
        // --------------------------------------------------------------------------
        private void btnJogN_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox[] JogVel = new TextBox[4];
            JogVel[0] = edtJogVel00; JogVel[1] = edtJogVel01; JogVel[2] = edtJogVel02; JogVel[3] = edtJogVel03;
            TextBox[] JogAcc = new TextBox[4];
            JogAcc[0] = edtJogAcc00; JogAcc[1] = edtJogAcc01; JogAcc[2] = edtJogAcc02; JogAcc[3] = edtJogAcc03;
            TextBox[] JogDec = new TextBox[4];
            JogDec[0] = edtJogDec00; JogDec[1] = edtJogDec01; JogDec[2] = edtJogDec02; JogDec[3] = edtJogDec03;
            CheckBox[] chkMoveMultiAxes = new CheckBox[4];
            chkMoveMultiAxes[0] = chkAxis00; chkMoveMultiAxes[1] = chkAxis01;
            chkMoveMultiAxes[2] = chkAxis02; chkMoveMultiAxes[3] = chkAxis03;

            uint lCount, lArrayIndex;
            double[] dMultiJogVel = { 0.0, 0.0, 0.0, 0.0 }, dMultiJogAcc = { 0.0, 0.0, 0.0, 0.0 }, dMultiJogDec = { 0.0, 0.0, 0.0, 0.0 };

            lArrayIndex = 0;

            for (lCount = 0; lCount < 4; lCount++)
            {
                if (chkMoveMultiAxes[lCount].Checked)
                {
                    dMultiJogVel[lArrayIndex] = -(Convert.ToDouble(JogVel[lCount].Text));
                    dMultiJogAcc[lArrayIndex] = Convert.ToDouble(JogAcc[lCount].Text);
                    dMultiJogDec[lArrayIndex] = Convert.ToDouble(JogDec[lCount].Text);
                    ++lArrayIndex;
                }
            }
            //++ 지정한 축을 (-)방향으로 지정한 속도/가속도/감속도로 모션구동합니다.
            //duRetCode = CAXM.AxmMoveStartMultiVel((int)m_lMoveMultiAxesCount, m_lMoveMultiAxes, dMultiJogVel, dMultiJogAcc, dMultiJogDec);
            mc2xxstd.SscApi.sscJogStart(0, 1, m_lAxisNo, (int)double.Parse(JogVel[m_lAxisNo].Text.ToString()), (short)double.Parse(JogAcc[m_lAxisNo].Text.ToString()), (short)double.Parse(JogDec[m_lAxisNo].Text.ToString()), mc2xxstd.SscApi.SSC_DIR_MINUS);
        }

        // ++ =======================================================================
        // >> btnJogN_MouseUp(...) : "Move Jog(+/-)"버튼 Up시 호출되는 핸들러 함수.
        //  - 버튼 이벤트인 MouseUp 함수를 이용하여 조그 버튼을 구현 합니다.
        //  - Jog버튼 Up시 구동정지 함수를 호출하여 Jog 구동을 종료합니다.
        // --------------------------------------------------------------------------
        private void btnJogN_MouseUp(object sender, MouseEventArgs e)
        {
            //for (lCount = 0; lCount < m_lMoveMultiAxesCount; lCount++)
            //++ 지정한 축의 Jog구동(모션구동)을 종료합니다. 
            //CAXM.AxmMoveSStop(m_lMoveMultiAxes[lCount]);
            mc2xxstd.SscApi.sscJogStop(0, 1, m_lAxisNo);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Hide();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //CAXM.AxmSignalSetLimit(2, 0, 1, 1);
            mc2xxstd.SscApi.sscControlAlarmReset(0, 1);
            mc2xxstd.SscApi.sscOperationAlarmReset(0, 1, m_lAxisNo);
            mc2xxstd.SscApi.sscServoAlarmReset(0, 1, m_lAxisNo);
        }

        #endregion
    }
}
