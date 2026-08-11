using Seojin.RobotVision;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ALIGN_TEST
{
    public partial class Main_Form : Form
    {
        RealSensor Sensor;
        ElementHost _elementHost;
        Viewer_2D viewer_2D;

        public VisionFrame VisionFrame;

        InstanceSegmentation InstanceSegmentation;
        ExecuteSegmentation ExecuteSegmentation = new ExecuteSegmentation();

        List<CameraDeviceInfo> info;
        public VisionFrame CurrentVisionFrame { get; private set; }

        Bitmap currentBmp;

        Motion_Form motion_Form = null;

        private const double dResol = 0.0502;

        public int num = 0;
        private delegate void DisplayFrameAcquired(int number, bool trash);
        //private PixelDataConverter[] converter = new PixelDataConverter[2];
        private Stopwatch stopWatch = new Stopwatch();

        double[] dResult = new double[3];

        public Main_Form()
        {
            InitializeComponent();

            motion_Form = new Motion_Form(); // NullReferenceException 방지를 위해 생성자에서 초기화

            ViewInitialize();

            Sensor = new RealSensor();
            info = Sensor.GetDeviceList();

            CameraConnect();
            SegmentInitialize();
        }

        private void ViewInitialize()
        {
            viewer_2D = new Viewer_2D();

            _elementHost = new ElementHost { Dock = DockStyle.Fill };
            _elementHost.Child = viewer_2D;
            pnl_cam.Controls.Add(_elementHost);
        }

        private void SegmentInitialize()
        {
            InstanceSegmentation = new InstanceSegmentation();
            InstanceSegmentation.Initialize(@"D:\SEGMENT\test2\Run_20260721_101500\weights\best.onnx");
        }

        private void Inspect()
        {
            try
            {
                if (currentBmp == null)
                {
                    MessageBox.Show("먼저 이미지를 불러오세요.");
                    return;
                }

                InspectionData result = ExecuteSegmentation.GetContour(
                    currentBmp, InstanceSegmentation, CurrentVisionFrame, Sensor, viewer_2D);

                dResult[0] = result.P_Tx;
                dResult[1] = result.P_Ty;
                dResult[2] = result.P_Rx;

                Console.WriteLine($"TX : {result.P_Tx}");
                Console.WriteLine($"TY : {result.P_Ty}");
                Console.WriteLine($"RX : {result.P_Rx}");

                Label_view_Double(label_Cam1_Start_X, BasePoint.B_TX);
                Label_view_Double(label_Cam1_Start_Y, BasePoint.B_TY);
                Label_view_Double(label_Cam1_Start_Angle, BasePoint.B_RX);
                //    //Pixel 좌표계
                //Label_view_Double(label_Cam1_PIXEL_X, dx);
                //Label_view_Double(label_Cam1_PIXEL_Y, dy);

                Label_view_Double(label_Cam1_Insp_X, result.P_Tx);
                Label_view_Double(label_Cam1_Insp_Y, result.P_Ty);
                Label_view_Double(label_Cam1_Insp_Angle, result.P_Rx);

                Label_view_Double(label_Cam1_Sub_X, BasePoint.B_TX - result.P_Tx);
                Label_view_Double(label_Cam1_Sub_Y, BasePoint.B_TY - result.P_Ty);
                Label_view_Double(label_Cam1_Sub_Angle, BasePoint.B_RX - result.P_Rx);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Align()
        {

        }

        private void CameraConnect()
        {
            try
            {
                info = Sensor.GetDeviceList();
                if (info.Count > 0)
                {
                    Sensor.ConnectBySerial(info[0].SerialNumber);

                    if (info.Count > 1)
                        Sensor.ConnectBySerial(info[1].SerialNumber);
                }
                else
                {
                    MessageBox.Show("연결된 RealSense 카메라를 찾을 수 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GrabOnce()
        {
            try
            {
                // 5000ms 타임아웃 내에 프레임 그랩 성공 시
                if (Sensor.GrabOnce(out VisionFrame frame, 5000))
                {
                    // Color Bitmap과 DepthBytes가 동일한 FrameSet에서 나온 프레임을 보관합니다.
                    CurrentVisionFrame = frame;

                    viewer_2D.ProcessAndRenderFrame(frame, "COLOR", viewer_2D);

                    if (currentBmp != null)
                    {
                        currentBmp.Dispose();
                        currentBmp = null;
                    }

                    if (frame.ColorBytes != null && frame.ColorBytes.Length > 0)
                    {
                        currentBmp = Sensor.CreateBitmapFromVisionFrame(frame);
                    }
                    else
                    {
                        Debug.WriteLine("단일 캡처 경고: frame.ColorBytes가 비어 있습니다.");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"단일 캡처 에러: {ex.Message}");
            }
        }


        private void button_Motion_Click(object sender, EventArgs e)
        {
            motion_Form.Opacity = 100;
            motion_Form.Show();
        }

        private void button_ImgLoad_Click(object sender, EventArgs e)
        {
            #region Display 초기화

            #endregion
            #region 이미지 불러오기

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.bmp)|*.bmp|Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {

                }
                catch
                {
                    MessageBox.Show("이미지파일을 확인해주세요");
                }
            }
            #endregion
        }

        private void button_Inspection_Click(object sender, EventArgs e)
        {
            Inspect();
        }

        public void Label_view_Double(Label label, double dTemp)
        {
            if (label.InvokeRequired)
                label.BeginInvoke(new Action(() => label.Text = dTemp.ToString("#0.#0")));
            else
                label.Text = dTemp.ToString("#0.#0");
        }

        private void button_move_Click(object sender, EventArgs e)
        {
            double[] dTemp = dResult;
            //double[] dTemp = { 100, 30, 40 };
            motion_Form.Servo_On();
            //motion_Form.Servo_Clear();
            motion_Form.Servo_Move(dTemp, 100, 200, 200);
        }

        private void button_OneShot_Click(object sender, EventArgs e)
        {
            GrabOnce();
        }

        private void Main_Closing(object sender, FormClosingEventArgs e)
        {
            Sensor.DisconnectDevice();
            Sensor.Dispose();

            _elementHost.Dispose();
        }
    }

    public class BasePoint
    {
        public static double B_TX { get; set; } = 400; //test
        public static double B_TY { get; set; } = 200; //test
        public static double B_RX { get; set; } = 0; // test
    }
}

