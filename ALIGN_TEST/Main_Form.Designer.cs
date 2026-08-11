namespace ALIGN_TEST
{
    partial class Main_Form
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
            this.button_Motion = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Cam1_START_PIXEL_Y = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label_Cam1_START_PIXEL_X = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Cam1_PIXEL_Y = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Cam1_PIXEL_X = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Find_VPP = new System.Windows.Forms.Button();
            this.label_VPP_Path = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_MultiShot = new System.Windows.Forms.Button();
            this.button_OneShot = new System.Windows.Forms.Button();
            this.button_Inspection = new System.Windows.Forms.Button();
            this.button_ImgLoad = new System.Windows.Forms.Button();
            this.checkBox_Point1 = new System.Windows.Forms.CheckBox();
            this.pnl_cam = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_Y = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label_Cam1_Sub_Y = new System.Windows.Forms.Label();
            this.label_Cam1_Sub_X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Result_X = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label_Result_A = new System.Windows.Forms.Label();
            this.label_Result_Y = new System.Windows.Forms.Label();
            this.label_Cam1_Insp_Y = new System.Windows.Forms.Label();
            this.label_Cam1_Insp_X = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_Cam1_Start_Y = new System.Windows.Forms.Label();
            this.label_Cam1_Start_X = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Calc_Y = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Calc_X = new System.Windows.Forms.Label();
            this.label_Calc_A = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_X = new System.Windows.Forms.NumericUpDown();
            this.button_CAM = new System.Windows.Forms.Button();
            this.button_move = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Cam1_Start_Angle = new System.Windows.Forms.Label();
            this.label_Cam1_Insp_Angle = new System.Windows.Forms.Label();
            this.label_Cam1_Sub_Angle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Motion
            // 
            this.button_Motion.Location = new System.Drawing.Point(8, 644);
            this.button_Motion.Name = "button_Motion";
            this.button_Motion.Size = new System.Drawing.Size(119, 54);
            this.button_Motion.TabIndex = 15;
            this.button_Motion.Text = "Motion";
            this.button_Motion.UseVisualStyleBackColor = true;
            this.button_Motion.Click += new System.EventHandler(this.button_Motion_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pnl_cam, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.896384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.310241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.62963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.384083F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.777778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.592593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 619);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel10.Controls.Add(this.label_Cam1_START_PIXEL_Y, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.label20, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.label_Cam1_START_PIXEL_X, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 460);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(935, 33);
            this.tableLayoutPanel10.TabIndex = 16;
            // 
            // label_Cam1_START_PIXEL_Y
            // 
            this.label_Cam1_START_PIXEL_Y.AutoSize = true;
            this.label_Cam1_START_PIXEL_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_START_PIXEL_Y.Location = new System.Drawing.Point(702, 3);
            this.label_Cam1_START_PIXEL_Y.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_START_PIXEL_Y.Name = "label_Cam1_START_PIXEL_Y";
            this.label_Cam1_START_PIXEL_Y.Size = new System.Drawing.Size(230, 27);
            this.label_Cam1_START_PIXEL_Y.TabIndex = 3;
            this.label_Cam1_START_PIXEL_Y.Text = "0";
            this.label_Cam1_START_PIXEL_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(469, 3);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(227, 27);
            this.label20.TabIndex = 2;
            this.label20.Text = "Y(pixel) 원점 : ";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Cam1_START_PIXEL_X
            // 
            this.label_Cam1_START_PIXEL_X.AutoSize = true;
            this.label_Cam1_START_PIXEL_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_START_PIXEL_X.Location = new System.Drawing.Point(236, 3);
            this.label_Cam1_START_PIXEL_X.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_START_PIXEL_X.Name = "label_Cam1_START_PIXEL_X";
            this.label_Cam1_START_PIXEL_X.Size = new System.Drawing.Size(227, 27);
            this.label_Cam1_START_PIXEL_X.TabIndex = 1;
            this.label_Cam1_START_PIXEL_X.Text = "0";
            this.label_Cam1_START_PIXEL_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Location = new System.Drawing.Point(3, 3);
            this.label23.Margin = new System.Windows.Forms.Padding(3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(227, 27);
            this.label23.TabIndex = 0;
            this.label23.Text = "X(pixel) 원점 : ";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 502);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(935, 35);
            this.tableLayoutPanel9.TabIndex = 15;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 582);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(935, 34);
            this.tableLayoutPanel7.TabIndex = 14;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel6.Controls.Add(this.label_Cam1_PIXEL_Y, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label_Cam1_PIXEL_X, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 543);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(935, 33);
            this.tableLayoutPanel6.TabIndex = 13;
            // 
            // label_Cam1_PIXEL_Y
            // 
            this.label_Cam1_PIXEL_Y.AutoSize = true;
            this.label_Cam1_PIXEL_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_PIXEL_Y.Location = new System.Drawing.Point(702, 3);
            this.label_Cam1_PIXEL_Y.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_PIXEL_Y.Name = "label_Cam1_PIXEL_Y";
            this.label_Cam1_PIXEL_Y.Size = new System.Drawing.Size(230, 27);
            this.label_Cam1_PIXEL_Y.TabIndex = 3;
            this.label_Cam1_PIXEL_Y.Text = "0";
            this.label_Cam1_PIXEL_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(469, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y(pixel) : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Cam1_PIXEL_X
            // 
            this.label_Cam1_PIXEL_X.AutoSize = true;
            this.label_Cam1_PIXEL_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_PIXEL_X.Location = new System.Drawing.Point(236, 3);
            this.label_Cam1_PIXEL_X.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_PIXEL_X.Name = "label_Cam1_PIXEL_X";
            this.label_Cam1_PIXEL_X.Size = new System.Drawing.Size(227, 27);
            this.label_Cam1_PIXEL_X.TabIndex = 1;
            this.label_Cam1_PIXEL_X.Text = "0";
            this.label_Cam1_PIXEL_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "X(pixel) : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.Controls.Add(this.button_Find_VPP, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_VPP_Path, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(438, 31);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // button_Find_VPP
            // 
            this.button_Find_VPP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Find_VPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Find_VPP.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold);
            this.button_Find_VPP.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Find_VPP.Location = new System.Drawing.Point(349, 3);
            this.button_Find_VPP.Name = "button_Find_VPP";
            this.button_Find_VPP.Size = new System.Drawing.Size(86, 25);
            this.button_Find_VPP.TabIndex = 5;
            this.button_Find_VPP.Text = "...";
            this.button_Find_VPP.UseVisualStyleBackColor = false;
            // 
            // label_VPP_Path
            // 
            this.label_VPP_Path.AutoSize = true;
            this.label_VPP_Path.BackColor = System.Drawing.Color.White;
            this.label_VPP_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_VPP_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_VPP_Path.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VPP_Path.ForeColor = System.Drawing.Color.Black;
            this.label_VPP_Path.Location = new System.Drawing.Point(1, 0);
            this.label_VPP_Path.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_VPP_Path.Name = "label_VPP_Path";
            this.label_VPP_Path.Padding = new System.Windows.Forms.Padding(3);
            this.label_VPP_Path.Size = new System.Drawing.Size(344, 31);
            this.label_VPP_Path.TabIndex = 4;
            this.label_VPP_Path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.00018F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9987F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0002F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0007F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.00022F));
            this.tableLayoutPanel4.Controls.Add(this.button_MultiShot, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_OneShot, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_Inspection, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_ImgLoad, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.checkBox_Point1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 401);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(935, 43);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // button_MultiShot
            // 
            this.button_MultiShot.BackColor = System.Drawing.Color.Gray;
            this.button_MultiShot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_MultiShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MultiShot.ForeColor = System.Drawing.Color.Black;
            this.button_MultiShot.Location = new System.Drawing.Point(357, 3);
            this.button_MultiShot.Name = "button_MultiShot";
            this.button_MultiShot.Size = new System.Drawing.Size(181, 37);
            this.button_MultiShot.TabIndex = 17;
            this.button_MultiShot.Text = "Multi Shot";
            this.button_MultiShot.UseVisualStyleBackColor = false;
            // 
            // button_OneShot
            // 
            this.button_OneShot.BackColor = System.Drawing.Color.Gray;
            this.button_OneShot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OneShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OneShot.ForeColor = System.Drawing.Color.Black;
            this.button_OneShot.Location = new System.Drawing.Point(171, 3);
            this.button_OneShot.Name = "button_OneShot";
            this.button_OneShot.Size = new System.Drawing.Size(180, 37);
            this.button_OneShot.TabIndex = 16;
            this.button_OneShot.Text = "One Shot";
            this.button_OneShot.UseVisualStyleBackColor = false;
            this.button_OneShot.Click += new System.EventHandler(this.button_OneShot_Click);
            // 
            // button_Inspection
            // 
            this.button_Inspection.BackColor = System.Drawing.Color.Gray;
            this.button_Inspection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Inspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Inspection.ForeColor = System.Drawing.Color.Black;
            this.button_Inspection.Location = new System.Drawing.Point(731, 3);
            this.button_Inspection.Name = "button_Inspection";
            this.button_Inspection.Size = new System.Drawing.Size(201, 37);
            this.button_Inspection.TabIndex = 14;
            this.button_Inspection.Text = "INSPECTION";
            this.button_Inspection.UseVisualStyleBackColor = false;
            this.button_Inspection.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Inspection_Click);
            // 
            // button_ImgLoad
            // 
            this.button_ImgLoad.BackColor = System.Drawing.Color.Gray;
            this.button_ImgLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ImgLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ImgLoad.ForeColor = System.Drawing.Color.Black;
            this.button_ImgLoad.Location = new System.Drawing.Point(544, 3);
            this.button_ImgLoad.Name = "button_ImgLoad";
            this.button_ImgLoad.Size = new System.Drawing.Size(181, 37);
            this.button_ImgLoad.TabIndex = 12;
            this.button_ImgLoad.Text = "IMAGE LOAD1";
            this.button_ImgLoad.UseVisualStyleBackColor = false;
            this.button_ImgLoad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_ImgLoad_Click);
            // 
            // checkBox_Point1
            // 
            this.checkBox_Point1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Point1.AutoSize = true;
            this.checkBox_Point1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox_Point1.Location = new System.Drawing.Point(51, 6);
            this.checkBox_Point1.Name = "checkBox_Point1";
            this.checkBox_Point1.Size = new System.Drawing.Size(66, 30);
            this.checkBox_Point1.TabIndex = 15;
            this.checkBox_Point1.Text = "Start Point";
            this.checkBox_Point1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Point1.UseVisualStyleBackColor = true;
            // 
            // pnl_cam
            // 
            this.pnl_cam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_cam.Location = new System.Drawing.Point(3, 40);
            this.pnl_cam.Name = "pnl_cam";
            this.pnl_cam.Size = new System.Drawing.Size(935, 332);
            this.pnl_cam.TabIndex = 17;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel8.Controls.Add(this.numericUpDown_Y, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label_Cam1_Sub_Y, 2, 4);
            this.tableLayoutPanel8.Controls.Add(this.label_Cam1_Sub_X, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label_Result_X, 1, 9);
            this.tableLayoutPanel8.Controls.Add(this.label31, 0, 9);
            this.tableLayoutPanel8.Controls.Add(this.label_Result_A, 3, 9);
            this.tableLayoutPanel8.Controls.Add(this.label_Result_Y, 2, 9);
            this.tableLayoutPanel8.Controls.Add(this.label_Cam1_Insp_Y, 2, 3);
            this.tableLayoutPanel8.Controls.Add(this.label_Cam1_Insp_X, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.label_Cam1_Start_Y, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.label_Cam1_Start_X, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.label12, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label_Calc_Y, 2, 8);
            this.tableLayoutPanel8.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel8.Controls.Add(this.label_Calc_X, 1, 8);
            this.tableLayoutPanel8.Controls.Add(this.label_Calc_A, 3, 8);
            this.tableLayoutPanel8.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.numericUpDown_X, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.label_Cam1_Sub_Angle, 3, 4);
            this.tableLayoutPanel8.Controls.Add(this.label_Cam1_Insp_Angle, 3, 3);
            this.tableLayoutPanel8.Controls.Add(this.label_Cam1_Start_Angle, 3, 2);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(952, 10);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 10;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999146F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999101F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999146F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999146F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00243F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999146F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999146F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00243F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999146F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00114F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(310, 619);
            this.tableLayoutPanel8.TabIndex = 17;
            // 
            // numericUpDown_Y
            // 
            this.numericUpDown_Y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Y.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_Y.Location = new System.Drawing.Point(157, 81);
            this.numericUpDown_Y.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Y.Name = "numericUpDown_Y";
            this.numericUpDown_Y.Size = new System.Drawing.Size(70, 21);
            this.numericUpDown_Y.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 55);
            this.label9.TabIndex = 37;
            this.label9.Text = "제품 크기";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Cam1_Sub_Y
            // 
            this.label_Cam1_Sub_Y.AutoSize = true;
            this.label_Cam1_Sub_Y.BackColor = System.Drawing.Color.Honeydew;
            this.label_Cam1_Sub_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_Sub_Y.Location = new System.Drawing.Point(157, 247);
            this.label_Cam1_Sub_Y.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_Sub_Y.Name = "label_Cam1_Sub_Y";
            this.label_Cam1_Sub_Y.Size = new System.Drawing.Size(71, 55);
            this.label_Cam1_Sub_Y.TabIndex = 36;
            this.label_Cam1_Sub_Y.Text = "0";
            this.label_Cam1_Sub_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Cam1_Sub_X
            // 
            this.label_Cam1_Sub_X.AutoSize = true;
            this.label_Cam1_Sub_X.BackColor = System.Drawing.Color.Honeydew;
            this.label_Cam1_Sub_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_Sub_X.Location = new System.Drawing.Point(80, 247);
            this.label_Cam1_Sub_X.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_Sub_X.Name = "label_Cam1_Sub_X";
            this.label_Cam1_Sub_X.Size = new System.Drawing.Size(71, 55);
            this.label_Cam1_Sub_X.TabIndex = 35;
            this.label_Cam1_Sub_X.Text = "0";
            this.label_Cam1_Sub_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 55);
            this.label2.TabIndex = 30;
            this.label2.Text = "mm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Result_X
            // 
            this.label_Result_X.AutoSize = true;
            this.label_Result_X.BackColor = System.Drawing.Color.PaleGreen;
            this.label_Result_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Result_X.Location = new System.Drawing.Point(80, 552);
            this.label_Result_X.Margin = new System.Windows.Forms.Padding(3);
            this.label_Result_X.Name = "label_Result_X";
            this.label_Result_X.Size = new System.Drawing.Size(71, 64);
            this.label_Result_X.TabIndex = 29;
            this.label_Result_X.Text = "0";
            this.label_Result_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.PaleGreen;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Location = new System.Drawing.Point(3, 552);
            this.label31.Margin = new System.Windows.Forms.Padding(3);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 64);
            this.label31.TabIndex = 28;
            this.label31.Text = "Result";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Result_A
            // 
            this.label_Result_A.AutoSize = true;
            this.label_Result_A.BackColor = System.Drawing.Color.PaleGreen;
            this.label_Result_A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Result_A.Location = new System.Drawing.Point(234, 552);
            this.label_Result_A.Margin = new System.Windows.Forms.Padding(3);
            this.label_Result_A.Name = "label_Result_A";
            this.label_Result_A.Size = new System.Drawing.Size(73, 64);
            this.label_Result_A.TabIndex = 27;
            this.label_Result_A.Text = "0";
            this.label_Result_A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Result_Y
            // 
            this.label_Result_Y.AutoSize = true;
            this.label_Result_Y.BackColor = System.Drawing.Color.PaleGreen;
            this.label_Result_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Result_Y.Location = new System.Drawing.Point(157, 552);
            this.label_Result_Y.Margin = new System.Windows.Forms.Padding(3);
            this.label_Result_Y.Name = "label_Result_Y";
            this.label_Result_Y.Size = new System.Drawing.Size(71, 64);
            this.label_Result_Y.TabIndex = 26;
            this.label_Result_Y.Text = "0";
            this.label_Result_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Cam1_Insp_Y
            // 
            this.label_Cam1_Insp_Y.AutoSize = true;
            this.label_Cam1_Insp_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_Insp_Y.Location = new System.Drawing.Point(157, 186);
            this.label_Cam1_Insp_Y.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_Insp_Y.Name = "label_Cam1_Insp_Y";
            this.label_Cam1_Insp_Y.Size = new System.Drawing.Size(71, 55);
            this.label_Cam1_Insp_Y.TabIndex = 15;
            this.label_Cam1_Insp_Y.Text = "0";
            this.label_Cam1_Insp_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Cam1_Insp_X
            // 
            this.label_Cam1_Insp_X.AutoSize = true;
            this.label_Cam1_Insp_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_Insp_X.Location = new System.Drawing.Point(80, 186);
            this.label_Cam1_Insp_X.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_Insp_X.Name = "label_Cam1_Insp_X";
            this.label_Cam1_Insp_X.Size = new System.Drawing.Size(71, 55);
            this.label_Cam1_Insp_X.TabIndex = 14;
            this.label_Cam1_Insp_X.Text = "0";
            this.label_Cam1_Insp_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 186);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 55);
            this.label17.TabIndex = 13;
            this.label17.Text = "CAM1 측정";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Cam1_Start_Y
            // 
            this.label_Cam1_Start_Y.AutoSize = true;
            this.label_Cam1_Start_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_Start_Y.Location = new System.Drawing.Point(157, 125);
            this.label_Cam1_Start_Y.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_Start_Y.Name = "label_Cam1_Start_Y";
            this.label_Cam1_Start_Y.Size = new System.Drawing.Size(71, 55);
            this.label_Cam1_Start_Y.TabIndex = 11;
            this.label_Cam1_Start_Y.Text = "0";
            this.label_Cam1_Start_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Cam1_Start_X
            // 
            this.label_Cam1_Start_X.AutoSize = true;
            this.label_Cam1_Start_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_Start_X.Location = new System.Drawing.Point(80, 125);
            this.label_Cam1_Start_X.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_Start_X.Name = "label_Cam1_Start_X";
            this.label_Cam1_Start_X.Size = new System.Drawing.Size(71, 55);
            this.label_Cam1_Start_X.TabIndex = 10;
            this.label_Cam1_Start_X.Text = "0";
            this.label_Cam1_Start_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 125);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 55);
            this.label13.TabIndex = 9;
            this.label13.Text = "CAM1 원점";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(234, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 55);
            this.label12.TabIndex = 8;
            this.label12.Text = "ANGLE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(157, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 55);
            this.label11.TabIndex = 7;
            this.label11.Text = "Y";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(80, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 55);
            this.label10.TabIndex = 6;
            this.label10.Text = "X";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Calc_Y
            // 
            this.label_Calc_Y.AutoSize = true;
            this.label_Calc_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Calc_Y.Location = new System.Drawing.Point(157, 491);
            this.label_Calc_Y.Margin = new System.Windows.Forms.Padding(3);
            this.label_Calc_Y.Name = "label_Calc_Y";
            this.label_Calc_Y.Size = new System.Drawing.Size(71, 55);
            this.label_Calc_Y.TabIndex = 5;
            this.label_Calc_Y.Text = "0";
            this.label_Calc_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 491);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 55);
            this.label8.TabIndex = 4;
            this.label8.Text = "Calc :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Calc_X
            // 
            this.label_Calc_X.AutoSize = true;
            this.label_Calc_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Calc_X.Location = new System.Drawing.Point(80, 491);
            this.label_Calc_X.Margin = new System.Windows.Forms.Padding(3);
            this.label_Calc_X.Name = "label_Calc_X";
            this.label_Calc_X.Size = new System.Drawing.Size(71, 55);
            this.label_Calc_X.TabIndex = 3;
            this.label_Calc_X.Text = "0";
            this.label_Calc_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Calc_A
            // 
            this.label_Calc_A.AutoSize = true;
            this.label_Calc_A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Calc_A.Location = new System.Drawing.Point(234, 491);
            this.label_Calc_A.Margin = new System.Windows.Forms.Padding(3);
            this.label_Calc_A.Name = "label_Calc_A";
            this.label_Calc_A.Size = new System.Drawing.Size(73, 55);
            this.label_Calc_A.TabIndex = 2;
            this.label_Calc_A.Text = "0";
            this.label_Calc_A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 55);
            this.label5.TabIndex = 31;
            this.label5.Text = "CAM1 차이";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_X
            // 
            this.numericUpDown_X.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_X.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_X.Location = new System.Drawing.Point(80, 81);
            this.numericUpDown_X.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_X.Name = "numericUpDown_X";
            this.numericUpDown_X.Size = new System.Drawing.Size(70, 21);
            this.numericUpDown_X.TabIndex = 38;
            // 
            // button_CAM
            // 
            this.button_CAM.Location = new System.Drawing.Point(142, 644);
            this.button_CAM.Name = "button_CAM";
            this.button_CAM.Size = new System.Drawing.Size(119, 54);
            this.button_CAM.TabIndex = 18;
            this.button_CAM.Text = "CAM";
            this.button_CAM.UseVisualStyleBackColor = true;
            // 
            // button_move
            // 
            this.button_move.BackColor = System.Drawing.Color.Gray;
            this.button_move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_move.ForeColor = System.Drawing.Color.Black;
            this.button_move.Location = new System.Drawing.Point(952, 635);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(98, 45);
            this.button_move.TabIndex = 19;
            this.button_move.Text = "Move";
            this.button_move.UseVisualStyleBackColor = false;
            this.button_move.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_move_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_move);
            this.panel1.Controls.Add(this.button_CAM);
            this.panel1.Controls.Add(this.tableLayoutPanel8);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.button_Motion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 703);
            this.panel1.TabIndex = 0;
            // 
            // label_Cam1_Start_Angle
            // 
            this.label_Cam1_Start_Angle.AutoSize = true;
            this.label_Cam1_Start_Angle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_Start_Angle.Location = new System.Drawing.Point(234, 125);
            this.label_Cam1_Start_Angle.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_Start_Angle.Name = "label_Cam1_Start_Angle";
            this.label_Cam1_Start_Angle.Size = new System.Drawing.Size(73, 55);
            this.label_Cam1_Start_Angle.TabIndex = 40;
            this.label_Cam1_Start_Angle.Text = "0";
            this.label_Cam1_Start_Angle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Cam1_Insp_Angle
            // 
            this.label_Cam1_Insp_Angle.AutoSize = true;
            this.label_Cam1_Insp_Angle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_Insp_Angle.Location = new System.Drawing.Point(234, 186);
            this.label_Cam1_Insp_Angle.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_Insp_Angle.Name = "label_Cam1_Insp_Angle";
            this.label_Cam1_Insp_Angle.Size = new System.Drawing.Size(73, 55);
            this.label_Cam1_Insp_Angle.TabIndex = 41;
            this.label_Cam1_Insp_Angle.Text = "0";
            this.label_Cam1_Insp_Angle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Cam1_Sub_Angle
            // 
            this.label_Cam1_Sub_Angle.AutoSize = true;
            this.label_Cam1_Sub_Angle.BackColor = System.Drawing.Color.Honeydew;
            this.label_Cam1_Sub_Angle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Cam1_Sub_Angle.Location = new System.Drawing.Point(234, 247);
            this.label_Cam1_Sub_Angle.Margin = new System.Windows.Forms.Padding(3);
            this.label_Cam1_Sub_Angle.Name = "label_Cam1_Sub_Angle";
            this.label_Cam1_Sub_Angle.Size = new System.Drawing.Size(73, 55);
            this.label_Cam1_Sub_Angle.TabIndex = 42;
            this.label_Cam1_Sub_Angle.Text = "0";
            this.label_Cam1_Sub_Angle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 713);
            this.Controls.Add(this.panel1);
            this.Name = "Main_Form";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Main Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Motion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label_Cam1_START_PIXEL_Y;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label_Cam1_START_PIXEL_X;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label_Cam1_PIXEL_Y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Cam1_PIXEL_X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Find_VPP;
        private System.Windows.Forms.Label label_VPP_Path;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_MultiShot;
        private System.Windows.Forms.Button button_OneShot;
        private System.Windows.Forms.Button button_Inspection;
        private System.Windows.Forms.Button button_ImgLoad;
        private System.Windows.Forms.CheckBox checkBox_Point1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.NumericUpDown numericUpDown_Y;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_Cam1_Sub_Y;
        private System.Windows.Forms.Label label_Cam1_Sub_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Result_X;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label_Result_A;
        private System.Windows.Forms.Label label_Result_Y;
        private System.Windows.Forms.Label label_Cam1_Insp_Y;
        private System.Windows.Forms.Label label_Cam1_Insp_X;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_Cam1_Start_Y;
        private System.Windows.Forms.Label label_Cam1_Start_X;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_Calc_Y;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Calc_X;
        private System.Windows.Forms.Label label_Calc_A;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_X;
        private System.Windows.Forms.Button button_CAM;
        private System.Windows.Forms.Button button_move;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_cam;
        private System.Windows.Forms.Label label_Cam1_Sub_Angle;
        private System.Windows.Forms.Label label_Cam1_Insp_Angle;
        private System.Windows.Forms.Label label_Cam1_Start_Angle;
    }
}

