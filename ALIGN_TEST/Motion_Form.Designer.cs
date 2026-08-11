
namespace ALIGN_TEST
{
    partial class Motion_Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnJogN = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.edtJogDec02 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.edtJogDec01 = new System.Windows.Forms.TextBox();
            this.btnPosStop = new System.Windows.Forms.Button();
            this.btnPosMove = new System.Windows.Forms.Button();
            this.edtMoveDec03 = new System.Windows.Forms.TextBox();
            this.edtMoveDec02 = new System.Windows.Forms.TextBox();
            this.edtMoveDec01 = new System.Windows.Forms.TextBox();
            this.edtMoveDec00 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edtMoveAcc03 = new System.Windows.Forms.TextBox();
            this.edtMoveVel00 = new System.Windows.Forms.TextBox();
            this.edtMoveAcc02 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtMoveAcc01 = new System.Windows.Forms.TextBox();
            this.btnJogP = new System.Windows.Forms.Button();
            this.edtJogDec03 = new System.Windows.Forms.TextBox();
            this.edtJogVel00 = new System.Windows.Forms.TextBox();
            this.grpMultiJogMove = new System.Windows.Forms.GroupBox();
            this.edtJogDec00 = new System.Windows.Forms.TextBox();
            this.edtJogVel01 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edtJogVel02 = new System.Windows.Forms.TextBox();
            this.edtJogAcc03 = new System.Windows.Forms.TextBox();
            this.edtJogVel03 = new System.Windows.Forms.TextBox();
            this.edtJogAcc02 = new System.Windows.Forms.TextBox();
            this.edtJogAcc00 = new System.Windows.Forms.TextBox();
            this.edtJogAcc01 = new System.Windows.Forms.TextBox();
            this.tmDisplay = new System.Windows.Forms.Timer(this.components);
            this.edtMovePos00 = new System.Windows.Forms.TextBox();
            this.edtMovePos02 = new System.Windows.Forms.TextBox();
            this.btnPosClear = new System.Windows.Forms.Button();
            this.edtCmdVel03 = new System.Windows.Forms.TextBox();
            this.edtCmdVel02 = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.cboSelAxis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtCmdVel01 = new System.Windows.Forms.TextBox();
            this.edtCmdVel00 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtActPos03 = new System.Windows.Forms.TextBox();
            this.edtActPos02 = new System.Windows.Forms.TextBox();
            this.edtActPos01 = new System.Windows.Forms.TextBox();
            this.edtActPos00 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gprPositionMonitor = new System.Windows.Forms.GroupBox();
            this.edtCmdPos03 = new System.Windows.Forms.TextBox();
            this.edtCmdPos02 = new System.Windows.Forms.TextBox();
            this.edtCmdPos01 = new System.Windows.Forms.TextBox();
            this.edtCmdPos00 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAxis03 = new System.Windows.Forms.CheckBox();
            this.chkAxis02 = new System.Windows.Forms.CheckBox();
            this.chkAxis01 = new System.Windows.Forms.CheckBox();
            this.chkAxis00 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.edtMoveAcc00 = new System.Windows.Forms.TextBox();
            this.edtMovePos01 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtMoveVel03 = new System.Windows.Forms.TextBox();
            this.edtMovePos03 = new System.Windows.Forms.TextBox();
            this.edtMoveVel02 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtMoveVel01 = new System.Windows.Forms.TextBox();
            this.grpMultiPositionMove = new System.Windows.Forms.GroupBox();
            this.chkMoveBlock = new System.Windows.Forms.CheckBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.grpMultiJogMove.SuspendLayout();
            this.gprPositionMonitor.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpMultiPositionMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJogN
            // 
            this.btnJogN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnJogN.Location = new System.Drawing.Point(391, 56);
            this.btnJogN.Name = "btnJogN";
            this.btnJogN.Size = new System.Drawing.Size(66, 33);
            this.btnJogN.TabIndex = 45;
            this.btnJogN.Text = "Jog(-)";
            this.btnJogN.UseVisualStyleBackColor = true;
            this.btnJogN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogN_MouseDown);
            this.btnJogN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogN_MouseUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "Move Accel    :";
            // 
            // edtJogDec02
            // 
            this.edtJogDec02.Location = new System.Drawing.Point(246, 68);
            this.edtJogDec02.Name = "edtJogDec02";
            this.edtJogDec02.Size = new System.Drawing.Size(70, 21);
            this.edtJogDec02.TabIndex = 32;
            this.edtJogDec02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "Move Velocity :";
            // 
            // edtJogDec01
            // 
            this.edtJogDec01.Location = new System.Drawing.Point(173, 68);
            this.edtJogDec01.Name = "edtJogDec01";
            this.edtJogDec01.Size = new System.Drawing.Size(70, 21);
            this.edtJogDec01.TabIndex = 31;
            this.edtJogDec01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPosStop
            // 
            this.btnPosStop.Location = new System.Drawing.Point(391, 80);
            this.btnPosStop.Name = "btnPosStop";
            this.btnPosStop.Size = new System.Drawing.Size(66, 33);
            this.btnPosStop.TabIndex = 43;
            this.btnPosStop.Text = "Stop";
            this.btnPosStop.UseVisualStyleBackColor = true;
            this.btnPosStop.Click += new System.EventHandler(this.btnPosStop_Click);
            // 
            // btnPosMove
            // 
            this.btnPosMove.Location = new System.Drawing.Point(391, 44);
            this.btnPosMove.Name = "btnPosMove";
            this.btnPosMove.Size = new System.Drawing.Size(66, 33);
            this.btnPosMove.TabIndex = 42;
            this.btnPosMove.Text = "Move";
            this.btnPosMove.UseVisualStyleBackColor = true;
            this.btnPosMove.Click += new System.EventHandler(this.btnPosMove_Click);
            // 
            // edtMoveDec03
            // 
            this.edtMoveDec03.Location = new System.Drawing.Point(319, 92);
            this.edtMoveDec03.Name = "edtMoveDec03";
            this.edtMoveDec03.Size = new System.Drawing.Size(70, 21);
            this.edtMoveDec03.TabIndex = 40;
            this.edtMoveDec03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtMoveDec02
            // 
            this.edtMoveDec02.Location = new System.Drawing.Point(246, 92);
            this.edtMoveDec02.Name = "edtMoveDec02";
            this.edtMoveDec02.Size = new System.Drawing.Size(70, 21);
            this.edtMoveDec02.TabIndex = 39;
            this.edtMoveDec02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtMoveDec01
            // 
            this.edtMoveDec01.Location = new System.Drawing.Point(173, 92);
            this.edtMoveDec01.Name = "edtMoveDec01";
            this.edtMoveDec01.Size = new System.Drawing.Size(70, 21);
            this.edtMoveDec01.TabIndex = 38;
            this.edtMoveDec01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtMoveDec00
            // 
            this.edtMoveDec00.Location = new System.Drawing.Point(100, 92);
            this.edtMoveDec00.Name = "edtMoveDec00";
            this.edtMoveDec00.Size = new System.Drawing.Size(70, 21);
            this.edtMoveDec00.TabIndex = 37;
            this.edtMoveDec00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "Move Decel    :";
            // 
            // edtMoveAcc03
            // 
            this.edtMoveAcc03.Location = new System.Drawing.Point(319, 68);
            this.edtMoveAcc03.Name = "edtMoveAcc03";
            this.edtMoveAcc03.Size = new System.Drawing.Size(70, 21);
            this.edtMoveAcc03.TabIndex = 35;
            this.edtMoveAcc03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtMoveVel00
            // 
            this.edtMoveVel00.Location = new System.Drawing.Point(100, 44);
            this.edtMoveVel00.Name = "edtMoveVel00";
            this.edtMoveVel00.Size = new System.Drawing.Size(70, 21);
            this.edtMoveVel00.TabIndex = 27;
            this.edtMoveVel00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtMoveAcc02
            // 
            this.edtMoveAcc02.Location = new System.Drawing.Point(246, 68);
            this.edtMoveAcc02.Name = "edtMoveAcc02";
            this.edtMoveAcc02.Size = new System.Drawing.Size(70, 21);
            this.edtMoveAcc02.TabIndex = 34;
            this.edtMoveAcc02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "Target Position:";
            // 
            // edtMoveAcc01
            // 
            this.edtMoveAcc01.Location = new System.Drawing.Point(173, 68);
            this.edtMoveAcc01.Name = "edtMoveAcc01";
            this.edtMoveAcc01.Size = new System.Drawing.Size(70, 21);
            this.edtMoveAcc01.TabIndex = 33;
            this.edtMoveAcc01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnJogP
            // 
            this.btnJogP.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnJogP.Location = new System.Drawing.Point(391, 20);
            this.btnJogP.Name = "btnJogP";
            this.btnJogP.Size = new System.Drawing.Size(66, 33);
            this.btnJogP.TabIndex = 44;
            this.btnJogP.Text = "Jog(+)";
            this.btnJogP.UseVisualStyleBackColor = true;
            this.btnJogP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogP_MouseDown);
            this.btnJogP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogP_MouseUp);
            // 
            // edtJogDec03
            // 
            this.edtJogDec03.Location = new System.Drawing.Point(319, 68);
            this.edtJogDec03.Name = "edtJogDec03";
            this.edtJogDec03.Size = new System.Drawing.Size(70, 21);
            this.edtJogDec03.TabIndex = 33;
            this.edtJogDec03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtJogVel00
            // 
            this.edtJogVel00.Location = new System.Drawing.Point(100, 20);
            this.edtJogVel00.Name = "edtJogVel00";
            this.edtJogVel00.Size = new System.Drawing.Size(70, 21);
            this.edtJogVel00.TabIndex = 20;
            this.edtJogVel00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpMultiJogMove
            // 
            this.grpMultiJogMove.Controls.Add(this.btnJogN);
            this.grpMultiJogMove.Controls.Add(this.btnJogP);
            this.grpMultiJogMove.Controls.Add(this.edtJogDec03);
            this.grpMultiJogMove.Controls.Add(this.label10);
            this.grpMultiJogMove.Controls.Add(this.edtJogDec02);
            this.grpMultiJogMove.Controls.Add(this.label11);
            this.grpMultiJogMove.Controls.Add(this.edtJogDec01);
            this.grpMultiJogMove.Controls.Add(this.edtJogVel00);
            this.grpMultiJogMove.Controls.Add(this.edtJogDec00);
            this.grpMultiJogMove.Controls.Add(this.edtJogVel01);
            this.grpMultiJogMove.Controls.Add(this.label9);
            this.grpMultiJogMove.Controls.Add(this.edtJogVel02);
            this.grpMultiJogMove.Controls.Add(this.edtJogAcc03);
            this.grpMultiJogMove.Controls.Add(this.edtJogVel03);
            this.grpMultiJogMove.Controls.Add(this.edtJogAcc02);
            this.grpMultiJogMove.Controls.Add(this.edtJogAcc00);
            this.grpMultiJogMove.Controls.Add(this.edtJogAcc01);
            this.grpMultiJogMove.Location = new System.Drawing.Point(12, 306);
            this.grpMultiJogMove.Name = "grpMultiJogMove";
            this.grpMultiJogMove.Size = new System.Drawing.Size(465, 98);
            this.grpMultiJogMove.TabIndex = 17;
            this.grpMultiJogMove.TabStop = false;
            this.grpMultiJogMove.Text = "< Multi Jog(Velocity) Move >";
            // 
            // edtJogDec00
            // 
            this.edtJogDec00.Location = new System.Drawing.Point(100, 68);
            this.edtJogDec00.Name = "edtJogDec00";
            this.edtJogDec00.Size = new System.Drawing.Size(70, 21);
            this.edtJogDec00.TabIndex = 30;
            this.edtJogDec00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtJogVel01
            // 
            this.edtJogVel01.Location = new System.Drawing.Point(173, 20);
            this.edtJogVel01.Name = "edtJogVel01";
            this.edtJogVel01.Size = new System.Drawing.Size(70, 21);
            this.edtJogVel01.TabIndex = 21;
            this.edtJogVel01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "Move Decel    :";
            // 
            // edtJogVel02
            // 
            this.edtJogVel02.Location = new System.Drawing.Point(246, 20);
            this.edtJogVel02.Name = "edtJogVel02";
            this.edtJogVel02.Size = new System.Drawing.Size(70, 21);
            this.edtJogVel02.TabIndex = 22;
            this.edtJogVel02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtJogAcc03
            // 
            this.edtJogAcc03.Location = new System.Drawing.Point(319, 44);
            this.edtJogAcc03.Name = "edtJogAcc03";
            this.edtJogAcc03.Size = new System.Drawing.Size(70, 21);
            this.edtJogAcc03.TabIndex = 28;
            this.edtJogAcc03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtJogVel03
            // 
            this.edtJogVel03.Location = new System.Drawing.Point(319, 20);
            this.edtJogVel03.Name = "edtJogVel03";
            this.edtJogVel03.Size = new System.Drawing.Size(70, 21);
            this.edtJogVel03.TabIndex = 23;
            this.edtJogVel03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtJogAcc02
            // 
            this.edtJogAcc02.Location = new System.Drawing.Point(246, 44);
            this.edtJogAcc02.Name = "edtJogAcc02";
            this.edtJogAcc02.Size = new System.Drawing.Size(70, 21);
            this.edtJogAcc02.TabIndex = 27;
            this.edtJogAcc02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtJogAcc00
            // 
            this.edtJogAcc00.Location = new System.Drawing.Point(100, 44);
            this.edtJogAcc00.Name = "edtJogAcc00";
            this.edtJogAcc00.Size = new System.Drawing.Size(70, 21);
            this.edtJogAcc00.TabIndex = 25;
            this.edtJogAcc00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtJogAcc01
            // 
            this.edtJogAcc01.Location = new System.Drawing.Point(173, 44);
            this.edtJogAcc01.Name = "edtJogAcc01";
            this.edtJogAcc01.Size = new System.Drawing.Size(70, 21);
            this.edtJogAcc01.TabIndex = 26;
            this.edtJogAcc01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tmDisplay
            // 
            this.tmDisplay.Enabled = true;
            this.tmDisplay.Tick += new System.EventHandler(this.tmDisplay_Tick);
            // 
            // edtMovePos00
            // 
            this.edtMovePos00.Location = new System.Drawing.Point(100, 20);
            this.edtMovePos00.Name = "edtMovePos00";
            this.edtMovePos00.Size = new System.Drawing.Size(70, 21);
            this.edtMovePos00.TabIndex = 22;
            this.edtMovePos00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtMovePos02
            // 
            this.edtMovePos02.Location = new System.Drawing.Point(246, 20);
            this.edtMovePos02.Name = "edtMovePos02";
            this.edtMovePos02.Size = new System.Drawing.Size(70, 21);
            this.edtMovePos02.TabIndex = 24;
            this.edtMovePos02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPosClear
            // 
            this.btnPosClear.Location = new System.Drawing.Point(391, 40);
            this.btnPosClear.Name = "btnPosClear";
            this.btnPosClear.Size = new System.Drawing.Size(66, 46);
            this.btnPosClear.TabIndex = 19;
            this.btnPosClear.Text = "Clear";
            this.btnPosClear.UseVisualStyleBackColor = true;
            this.btnPosClear.Click += new System.EventHandler(this.btnPosClear_Click);
            // 
            // edtCmdVel03
            // 
            this.edtCmdVel03.Location = new System.Drawing.Point(319, 89);
            this.edtCmdVel03.Name = "edtCmdVel03";
            this.edtCmdVel03.ReadOnly = true;
            this.edtCmdVel03.Size = new System.Drawing.Size(70, 21);
            this.edtCmdVel03.TabIndex = 18;
            this.edtCmdVel03.Text = "0.000";
            this.edtCmdVel03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtCmdVel02
            // 
            this.edtCmdVel02.Location = new System.Drawing.Point(246, 89);
            this.edtCmdVel02.Name = "edtCmdVel02";
            this.edtCmdVel02.ReadOnly = true;
            this.edtCmdVel02.Size = new System.Drawing.Size(70, 21);
            this.edtCmdVel02.TabIndex = 17;
            this.edtCmdVel02.Text = "0.000";
            this.edtCmdVel02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(339, 10);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(119, 21);
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // cboSelAxis
            // 
            this.cboSelAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelAxis.FormattingEnabled = true;
            this.cboSelAxis.Location = new System.Drawing.Point(132, 10);
            this.cboSelAxis.Name = "cboSelAxis";
            this.cboSelAxis.Size = new System.Drawing.Size(203, 20);
            this.cboSelAxis.TabIndex = 1;
            this.cboSelAxis.SelectedIndexChanged += new System.EventHandler(this.cboSelAxis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Axis No :";
            // 
            // edtCmdVel01
            // 
            this.edtCmdVel01.Location = new System.Drawing.Point(173, 89);
            this.edtCmdVel01.Name = "edtCmdVel01";
            this.edtCmdVel01.ReadOnly = true;
            this.edtCmdVel01.Size = new System.Drawing.Size(70, 21);
            this.edtCmdVel01.TabIndex = 16;
            this.edtCmdVel01.Text = "0.000";
            this.edtCmdVel01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtCmdVel00
            // 
            this.edtCmdVel00.Location = new System.Drawing.Point(100, 89);
            this.edtCmdVel00.Name = "edtCmdVel00";
            this.edtCmdVel00.ReadOnly = true;
            this.edtCmdVel00.Size = new System.Drawing.Size(70, 21);
            this.edtCmdVel00.TabIndex = 15;
            this.edtCmdVel00.Text = "0.000";
            this.edtCmdVel00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Command Vel :";
            // 
            // edtActPos03
            // 
            this.edtActPos03.Location = new System.Drawing.Point(319, 65);
            this.edtActPos03.Name = "edtActPos03";
            this.edtActPos03.ReadOnly = true;
            this.edtActPos03.Size = new System.Drawing.Size(70, 21);
            this.edtActPos03.TabIndex = 13;
            this.edtActPos03.Text = "0.000";
            this.edtActPos03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtActPos02
            // 
            this.edtActPos02.Location = new System.Drawing.Point(246, 65);
            this.edtActPos02.Name = "edtActPos02";
            this.edtActPos02.ReadOnly = true;
            this.edtActPos02.Size = new System.Drawing.Size(70, 21);
            this.edtActPos02.TabIndex = 12;
            this.edtActPos02.Text = "0.000";
            this.edtActPos02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtActPos01
            // 
            this.edtActPos01.Location = new System.Drawing.Point(173, 65);
            this.edtActPos01.Name = "edtActPos01";
            this.edtActPos01.ReadOnly = true;
            this.edtActPos01.Size = new System.Drawing.Size(70, 21);
            this.edtActPos01.TabIndex = 11;
            this.edtActPos01.Text = "0.000";
            this.edtActPos01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtActPos00
            // 
            this.edtActPos00.Location = new System.Drawing.Point(100, 65);
            this.edtActPos00.Name = "edtActPos00";
            this.edtActPos00.ReadOnly = true;
            this.edtActPos00.Size = new System.Drawing.Size(70, 21);
            this.edtActPos00.TabIndex = 10;
            this.edtActPos00.Text = "0.000";
            this.edtActPos00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Feedback Pos :";
            // 
            // gprPositionMonitor
            // 
            this.gprPositionMonitor.Controls.Add(this.btnPosClear);
            this.gprPositionMonitor.Controls.Add(this.edtCmdVel03);
            this.gprPositionMonitor.Controls.Add(this.edtCmdVel02);
            this.gprPositionMonitor.Controls.Add(this.edtCmdVel01);
            this.gprPositionMonitor.Controls.Add(this.edtCmdVel00);
            this.gprPositionMonitor.Controls.Add(this.label4);
            this.gprPositionMonitor.Controls.Add(this.edtActPos03);
            this.gprPositionMonitor.Controls.Add(this.edtActPos02);
            this.gprPositionMonitor.Controls.Add(this.edtActPos01);
            this.gprPositionMonitor.Controls.Add(this.edtActPos00);
            this.gprPositionMonitor.Controls.Add(this.label3);
            this.gprPositionMonitor.Controls.Add(this.edtCmdPos03);
            this.gprPositionMonitor.Controls.Add(this.edtCmdPos02);
            this.gprPositionMonitor.Controls.Add(this.edtCmdPos01);
            this.gprPositionMonitor.Controls.Add(this.edtCmdPos00);
            this.gprPositionMonitor.Controls.Add(this.label2);
            this.gprPositionMonitor.Controls.Add(this.chkAxis03);
            this.gprPositionMonitor.Controls.Add(this.chkAxis02);
            this.gprPositionMonitor.Controls.Add(this.chkAxis01);
            this.gprPositionMonitor.Controls.Add(this.chkAxis00);
            this.gprPositionMonitor.Location = new System.Drawing.Point(12, 54);
            this.gprPositionMonitor.Name = "gprPositionMonitor";
            this.gprPositionMonitor.Size = new System.Drawing.Size(465, 118);
            this.gprPositionMonitor.TabIndex = 15;
            this.gprPositionMonitor.TabStop = false;
            this.gprPositionMonitor.Text = "Position Monitor";
            // 
            // edtCmdPos03
            // 
            this.edtCmdPos03.Location = new System.Drawing.Point(319, 41);
            this.edtCmdPos03.Name = "edtCmdPos03";
            this.edtCmdPos03.ReadOnly = true;
            this.edtCmdPos03.Size = new System.Drawing.Size(70, 21);
            this.edtCmdPos03.TabIndex = 8;
            this.edtCmdPos03.Text = "0.000";
            this.edtCmdPos03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtCmdPos02
            // 
            this.edtCmdPos02.Location = new System.Drawing.Point(246, 41);
            this.edtCmdPos02.Name = "edtCmdPos02";
            this.edtCmdPos02.ReadOnly = true;
            this.edtCmdPos02.Size = new System.Drawing.Size(70, 21);
            this.edtCmdPos02.TabIndex = 7;
            this.edtCmdPos02.Text = "0.000";
            this.edtCmdPos02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtCmdPos01
            // 
            this.edtCmdPos01.Location = new System.Drawing.Point(173, 41);
            this.edtCmdPos01.Name = "edtCmdPos01";
            this.edtCmdPos01.ReadOnly = true;
            this.edtCmdPos01.Size = new System.Drawing.Size(70, 21);
            this.edtCmdPos01.TabIndex = 6;
            this.edtCmdPos01.Text = "0.000";
            this.edtCmdPos01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtCmdPos00
            // 
            this.edtCmdPos00.Location = new System.Drawing.Point(100, 41);
            this.edtCmdPos00.Name = "edtCmdPos00";
            this.edtCmdPos00.ReadOnly = true;
            this.edtCmdPos00.Size = new System.Drawing.Size(70, 21);
            this.edtCmdPos00.TabIndex = 5;
            this.edtCmdPos00.Text = "0.000";
            this.edtCmdPos00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Command Pos:";
            // 
            // chkAxis03
            // 
            this.chkAxis03.AutoSize = true;
            this.chkAxis03.Location = new System.Drawing.Point(323, 19);
            this.chkAxis03.Name = "chkAxis03";
            this.chkAxis03.Size = new System.Drawing.Size(61, 16);
            this.chkAxis03.TabIndex = 3;
            this.chkAxis03.Text = "Axis03";
            this.chkAxis03.UseVisualStyleBackColor = true;
            this.chkAxis03.Click += new System.EventHandler(this.chkAxis_Click);
            // 
            // chkAxis02
            // 
            this.chkAxis02.AutoSize = true;
            this.chkAxis02.Location = new System.Drawing.Point(249, 19);
            this.chkAxis02.Name = "chkAxis02";
            this.chkAxis02.Size = new System.Drawing.Size(61, 16);
            this.chkAxis02.TabIndex = 2;
            this.chkAxis02.Text = "Axis02";
            this.chkAxis02.UseVisualStyleBackColor = true;
            this.chkAxis02.Click += new System.EventHandler(this.chkAxis_Click);
            // 
            // chkAxis01
            // 
            this.chkAxis01.AutoSize = true;
            this.chkAxis01.Location = new System.Drawing.Point(176, 19);
            this.chkAxis01.Name = "chkAxis01";
            this.chkAxis01.Size = new System.Drawing.Size(61, 16);
            this.chkAxis01.TabIndex = 1;
            this.chkAxis01.Text = "Axis01";
            this.chkAxis01.UseVisualStyleBackColor = true;
            this.chkAxis01.Click += new System.EventHandler(this.chkAxis_Click);
            // 
            // chkAxis00
            // 
            this.chkAxis00.AutoSize = true;
            this.chkAxis00.Location = new System.Drawing.Point(102, 19);
            this.chkAxis00.Name = "chkAxis00";
            this.chkAxis00.Size = new System.Drawing.Size(65, 16);
            this.chkAxis00.TabIndex = 0;
            this.chkAxis00.Text = "Axis 00";
            this.chkAxis00.UseVisualStyleBackColor = true;
            this.chkAxis00.Click += new System.EventHandler(this.chkAxis_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLoadFile);
            this.groupBox4.Controls.Add(this.cboSelAxis);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 36);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // edtMoveAcc00
            // 
            this.edtMoveAcc00.Location = new System.Drawing.Point(100, 68);
            this.edtMoveAcc00.Name = "edtMoveAcc00";
            this.edtMoveAcc00.Size = new System.Drawing.Size(70, 21);
            this.edtMoveAcc00.TabIndex = 32;
            this.edtMoveAcc00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtMovePos01
            // 
            this.edtMovePos01.Location = new System.Drawing.Point(173, 20);
            this.edtMovePos01.Name = "edtMovePos01";
            this.edtMovePos01.Size = new System.Drawing.Size(70, 21);
            this.edtMovePos01.TabIndex = 23;
            this.edtMovePos01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "Move Accel    :";
            // 
            // edtMoveVel03
            // 
            this.edtMoveVel03.Location = new System.Drawing.Point(319, 44);
            this.edtMoveVel03.Name = "edtMoveVel03";
            this.edtMoveVel03.Size = new System.Drawing.Size(70, 21);
            this.edtMoveVel03.TabIndex = 30;
            this.edtMoveVel03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtMovePos03
            // 
            this.edtMovePos03.Location = new System.Drawing.Point(319, 20);
            this.edtMovePos03.Name = "edtMovePos03";
            this.edtMovePos03.Size = new System.Drawing.Size(70, 21);
            this.edtMovePos03.TabIndex = 25;
            this.edtMovePos03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtMoveVel02
            // 
            this.edtMoveVel02.Location = new System.Drawing.Point(246, 44);
            this.edtMoveVel02.Name = "edtMoveVel02";
            this.edtMoveVel02.Size = new System.Drawing.Size(70, 21);
            this.edtMoveVel02.TabIndex = 29;
            this.edtMoveVel02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "Move Velocity :";
            // 
            // edtMoveVel01
            // 
            this.edtMoveVel01.Location = new System.Drawing.Point(173, 44);
            this.edtMoveVel01.Name = "edtMoveVel01";
            this.edtMoveVel01.Size = new System.Drawing.Size(70, 21);
            this.edtMoveVel01.TabIndex = 28;
            this.edtMoveVel01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpMultiPositionMove
            // 
            this.grpMultiPositionMove.Controls.Add(this.chkMoveBlock);
            this.grpMultiPositionMove.Controls.Add(this.btnPosStop);
            this.grpMultiPositionMove.Controls.Add(this.btnPosMove);
            this.grpMultiPositionMove.Controls.Add(this.edtMoveDec03);
            this.grpMultiPositionMove.Controls.Add(this.edtMoveDec02);
            this.grpMultiPositionMove.Controls.Add(this.edtMoveDec01);
            this.grpMultiPositionMove.Controls.Add(this.edtMoveDec00);
            this.grpMultiPositionMove.Controls.Add(this.label8);
            this.grpMultiPositionMove.Controls.Add(this.edtMoveAcc03);
            this.grpMultiPositionMove.Controls.Add(this.edtMoveVel00);
            this.grpMultiPositionMove.Controls.Add(this.edtMoveAcc02);
            this.grpMultiPositionMove.Controls.Add(this.label7);
            this.grpMultiPositionMove.Controls.Add(this.edtMoveAcc01);
            this.grpMultiPositionMove.Controls.Add(this.edtMovePos00);
            this.grpMultiPositionMove.Controls.Add(this.edtMoveAcc00);
            this.grpMultiPositionMove.Controls.Add(this.edtMovePos01);
            this.grpMultiPositionMove.Controls.Add(this.label5);
            this.grpMultiPositionMove.Controls.Add(this.edtMovePos02);
            this.grpMultiPositionMove.Controls.Add(this.edtMoveVel03);
            this.grpMultiPositionMove.Controls.Add(this.edtMovePos03);
            this.grpMultiPositionMove.Controls.Add(this.edtMoveVel02);
            this.grpMultiPositionMove.Controls.Add(this.label6);
            this.grpMultiPositionMove.Controls.Add(this.edtMoveVel01);
            this.grpMultiPositionMove.Location = new System.Drawing.Point(12, 178);
            this.grpMultiPositionMove.Name = "grpMultiPositionMove";
            this.grpMultiPositionMove.Size = new System.Drawing.Size(465, 122);
            this.grpMultiPositionMove.TabIndex = 16;
            this.grpMultiPositionMove.TabStop = false;
            this.grpMultiPositionMove.Text = "< Multi Position Move >";
            // 
            // chkMoveBlock
            // 
            this.chkMoveBlock.AutoSize = true;
            this.chkMoveBlock.Location = new System.Drawing.Point(395, 20);
            this.chkMoveBlock.Name = "chkMoveBlock";
            this.chkMoveBlock.Size = new System.Drawing.Size(55, 16);
            this.chkMoveBlock.TabIndex = 45;
            this.chkMoveBlock.Text = "Block";
            this.chkMoveBlock.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(12, 410);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(145, 29);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "ALARM RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 29);
            this.button2.TabIndex = 18;
            this.button2.Text = "Axis02 Limit 비활성화";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(186, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "X,Y 축 1당 7.88888 Pixel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "세타 축 1당 0.072837º";
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Red;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button_Close.ForeColor = System.Drawing.Color.White;
            this.button_Close.Location = new System.Drawing.Point(351, 445);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(126, 49);
            this.button_Close.TabIndex = 121;
            this.button_Close.Text = "CLOSE";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Motion_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(495, 512);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.grpMultiJogMove);
            this.Controls.Add(this.gprPositionMonitor);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpMultiPositionMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Motion_Form";
            this.Text = "Motion";
            this.Load += new System.EventHandler(this.MoveMultiAxes_Load);
            this.grpMultiJogMove.ResumeLayout(false);
            this.grpMultiJogMove.PerformLayout();
            this.gprPositionMonitor.ResumeLayout(false);
            this.gprPositionMonitor.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpMultiPositionMove.ResumeLayout(false);
            this.grpMultiPositionMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtJogDec02;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edtJogDec01;
        private System.Windows.Forms.Button btnPosStop;
        private System.Windows.Forms.Button btnPosMove;
        private System.Windows.Forms.TextBox edtMoveDec03;
        private System.Windows.Forms.TextBox edtMoveDec02;
        private System.Windows.Forms.TextBox edtMoveDec01;
        private System.Windows.Forms.TextBox edtMoveDec00;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtMoveAcc03;
        private System.Windows.Forms.TextBox edtMoveVel00;
        private System.Windows.Forms.TextBox edtMoveAcc02;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtMoveAcc01;
        private System.Windows.Forms.Button btnJogP;
        private System.Windows.Forms.TextBox edtJogDec03;
        private System.Windows.Forms.TextBox edtJogVel00;
        private System.Windows.Forms.GroupBox grpMultiJogMove;
        private System.Windows.Forms.TextBox edtJogDec00;
        private System.Windows.Forms.TextBox edtJogVel01;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtJogVel02;
        private System.Windows.Forms.TextBox edtJogAcc03;
        private System.Windows.Forms.TextBox edtJogVel03;
        private System.Windows.Forms.TextBox edtJogAcc02;
        private System.Windows.Forms.TextBox edtJogAcc00;
        private System.Windows.Forms.TextBox edtJogAcc01;
        private System.Windows.Forms.Timer tmDisplay;
        private System.Windows.Forms.TextBox edtMovePos00;
        private System.Windows.Forms.TextBox edtMovePos02;
        private System.Windows.Forms.Button btnPosClear;
        private System.Windows.Forms.TextBox edtCmdVel03;
        private System.Windows.Forms.TextBox edtCmdVel02;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.ComboBox cboSelAxis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtCmdVel01;
        private System.Windows.Forms.TextBox edtCmdVel00;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtActPos03;
        private System.Windows.Forms.TextBox edtActPos02;
        private System.Windows.Forms.TextBox edtActPos01;
        private System.Windows.Forms.TextBox edtActPos00;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gprPositionMonitor;
        private System.Windows.Forms.TextBox edtCmdPos03;
        private System.Windows.Forms.TextBox edtCmdPos02;
        private System.Windows.Forms.TextBox edtCmdPos01;
        private System.Windows.Forms.TextBox edtCmdPos00;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAxis03;
        private System.Windows.Forms.CheckBox chkAxis02;
        private System.Windows.Forms.CheckBox chkAxis01;
        private System.Windows.Forms.CheckBox chkAxis00;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox edtMoveAcc00;
        private System.Windows.Forms.TextBox edtMovePos01;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtMoveVel03;
        private System.Windows.Forms.TextBox edtMovePos03;
        private System.Windows.Forms.TextBox edtMoveVel02;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtMoveVel01;
        private System.Windows.Forms.GroupBox grpMultiPositionMove;
        private System.Windows.Forms.CheckBox chkMoveBlock;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_Close;
    }
}

