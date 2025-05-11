namespace DataDisplay
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPortList = new System.Windows.Forms.ComboBox();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDataRate = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.zedGraphControlTemperature = new ZedGraph.ZedGraphControl();
            this.zedGraphControlHumidity = new ZedGraph.ZedGraphControl();
            this.listViewDataDisplay = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSelectToShow = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSelectToQuery = new System.Windows.Forms.ComboBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zedGraphControlHisHumi = new ZedGraph.ZedGraphControl();
            this.zedGraphControlHisTemp = new ZedGraph.ZedGraphControl();
            this.listViewHistoryData = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口号:";
            // 
            // comboBoxPortList
            // 
            this.comboBoxPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPortList.FormattingEnabled = true;
            this.comboBoxPortList.Location = new System.Drawing.Point(84, 19);
            this.comboBoxPortList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPortList.Name = "comboBoxPortList";
            this.comboBoxPortList.Size = new System.Drawing.Size(86, 26);
            this.comboBoxPortList.TabIndex = 2;
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.Location = new System.Drawing.Point(379, 18);
            this.buttonOpenPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(112, 35);
            this.buttonOpenPort.TabIndex = 3;
            this.buttonOpenPort.Text = "打开";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率:";
            // 
            // comboBoxDataRate
            // 
            this.comboBoxDataRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataRate.FormattingEnabled = true;
            this.comboBoxDataRate.Location = new System.Drawing.Point(267, 19);
            this.comboBoxDataRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDataRate.Name = "comboBoxDataRate";
            this.comboBoxDataRate.Size = new System.Drawing.Size(86, 26);
            this.comboBoxDataRate.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1563, 887);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.zedGraphControlHumidity);
            this.tabPage1.Controls.Add(this.listViewDataDisplay);
            this.tabPage1.Controls.Add(this.buttonOpenPort);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBoxSelectToShow);
            this.tabPage1.Controls.Add(this.comboBoxPortList);
            this.tabPage1.Controls.Add(this.comboBoxDataRate);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1555, 855);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "实时数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(975, 51);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(296, 18);
            this.label29.TabIndex = 53;
            this.label29.Text = "参赛组员：孟祥帅，奉毅哲，周文博";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(917, 723);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(112, 28);
            this.textBox11.TabIndex = 52;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(792, 733);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 18);
            this.label27.TabIndex = 51;
            this.label27.Text = "深径比:";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1070, 723);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(84, 28);
            this.button12.TabIndex = 50;
            this.button12.Text = "查询";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(472, 736);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(26, 18);
            this.label26.TabIndex = 49;
            this.label26.Text = "um";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(353, 726);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(112, 28);
            this.textBox10.TabIndex = 48;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(206, 736);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 18);
            this.label25.TabIndex = 47;
            this.label25.Text = "通孔深度:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label24.Location = new System.Drawing.Point(792, 789);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(278, 18);
            this.label24.TabIndex = 46;
            this.label24.Text = "孔不圆度=孔最大直径-孔最小直径";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1070, 492);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 28);
            this.button11.TabIndex = 45;
            this.button11.Text = "查询";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(514, 492);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 28);
            this.button10.TabIndex = 44;
            this.button10.Text = "查询";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1070, 661);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 28);
            this.button9.TabIndex = 43;
            this.button9.Text = "查询";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1070, 600);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 28);
            this.button8.TabIndex = 42;
            this.button8.Text = "查询";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1070, 548);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 28);
            this.button7.TabIndex = 41;
            this.button7.Text = "查询";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(514, 551);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 28);
            this.button6.TabIndex = 40;
            this.button6.Text = "查询";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(472, 562);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 18);
            this.label22.TabIndex = 39;
            this.label22.Text = "um";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(206, 561);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 18);
            this.label23.TabIndex = 38;
            this.label23.Text = "通孔直径:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(354, 552);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(112, 28);
            this.textBox9.TabIndex = 37;
            this.textBox9.Text = " ";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(514, 780);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 28);
            this.button5.TabIndex = 36;
            this.button5.Text = "查询";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(514, 668);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 28);
            this.button4.TabIndex = 35;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 609);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 28);
            this.button3.TabIndex = 34;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1070, 452);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 28);
            this.button2.TabIndex = 33;
            this.button2.Text = "设置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(792, 500);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 18);
            this.label21.TabIndex = 32;
            this.label21.Text = "测量较正值:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(917, 490);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(112, 28);
            this.textBox8.TabIndex = 31;
            this.textBox8.Text = "8.12";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(206, 500);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 18);
            this.label20.TabIndex = 29;
            this.label20.Text = "摄像头阈值:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(353, 490);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(112, 28);
            this.textBox7.TabIndex = 28;
            this.textBox7.Text = "80";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1038, 612);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 18);
            this.label16.TabIndex = 27;
            this.label16.Text = "mm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1038, 558);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 18);
            this.label17.TabIndex = 26;
            this.label17.Text = "mm";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(792, 612);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 18);
            this.label18.TabIndex = 25;
            this.label18.Text = "孔最小直径:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(792, 558);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 18);
            this.label19.TabIndex = 24;
            this.label19.Text = "孔最大直径:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(917, 602);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 28);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(917, 548);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(112, 28);
            this.textBox6.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1029, 671);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 18);
            this.label14.TabIndex = 21;
            this.label14.Text = "rad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(792, 671);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 18);
            this.label15.TabIndex = 20;
            this.label15.Text = "孔不圆度:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(917, 661);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 28);
            this.textBox4.TabIndex = 19;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(472, 782);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "rad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(206, 782);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 18);
            this.label13.TabIndex = 17;
            this.label13.Text = "通孔孔轴垂直度:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(353, 779);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 28);
            this.textBox3.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(472, 678);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "um";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(472, 619);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "um";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 681);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "通孔小直径:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 619);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "通孔大直径:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 668);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 28);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 609);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 28);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(975, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "华南师范大学全国光电设计大赛";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.zedGraphControlTemperature, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 73);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.73299F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.267003F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1502, 343);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // zedGraphControlTemperature
            // 
            this.zedGraphControlTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControlTemperature.Location = new System.Drawing.Point(6, 5);
            this.zedGraphControlTemperature.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.zedGraphControlTemperature.Name = "zedGraphControlTemperature";
            this.zedGraphControlTemperature.ScrollGrace = 0D;
            this.zedGraphControlTemperature.ScrollMaxX = 0D;
            this.zedGraphControlTemperature.ScrollMaxY = 0D;
            this.zedGraphControlTemperature.ScrollMaxY2 = 0D;
            this.zedGraphControlTemperature.ScrollMinX = 0D;
            this.zedGraphControlTemperature.ScrollMinY = 0D;
            this.zedGraphControlTemperature.ScrollMinY2 = 0D;
            this.zedGraphControlTemperature.Size = new System.Drawing.Size(1491, 324);
            this.zedGraphControlTemperature.TabIndex = 7;
            // 
            // zedGraphControlHumidity
            // 
            this.zedGraphControlHumidity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControlHumidity.Location = new System.Drawing.Point(53, 445);
            this.zedGraphControlHumidity.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.zedGraphControlHumidity.Name = "zedGraphControlHumidity";
            this.zedGraphControlHumidity.ScrollGrace = 0D;
            this.zedGraphControlHumidity.ScrollMaxX = 0D;
            this.zedGraphControlHumidity.ScrollMaxY = 0D;
            this.zedGraphControlHumidity.ScrollMaxY2 = 0D;
            this.zedGraphControlHumidity.ScrollMinX = 0D;
            this.zedGraphControlHumidity.ScrollMinY = 0D;
            this.zedGraphControlHumidity.ScrollMinY2 = 0D;
            this.zedGraphControlHumidity.Size = new System.Drawing.Size(25, 12);
            this.zedGraphControlHumidity.TabIndex = 6;
            this.zedGraphControlHumidity.Visible = false;
            this.zedGraphControlHumidity.Load += new System.EventHandler(this.zedGraphControlHumidity_Load);
            // 
            // listViewDataDisplay
            // 
            this.listViewDataDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewDataDisplay.HideSelection = false;
            this.listViewDataDisplay.Location = new System.Drawing.Point(19, 445);
            this.listViewDataDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewDataDisplay.Name = "listViewDataDisplay";
            this.listViewDataDisplay.Size = new System.Drawing.Size(13, 27);
            this.listViewDataDisplay.TabIndex = 5;
            this.listViewDataDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDataDisplay.Click += new System.EventHandler(this.listViewDataDisplay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "选择微孔参数号:";
            // 
            // comboBoxSelectToShow
            // 
            this.comboBoxSelectToShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectToShow.FormattingEnabled = true;
            this.comboBoxSelectToShow.Location = new System.Drawing.Point(663, 22);
            this.comboBoxSelectToShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSelectToShow.Name = "comboBoxSelectToShow";
            this.comboBoxSelectToShow.Size = new System.Drawing.Size(86, 26);
            this.comboBoxSelectToShow.TabIndex = 2;
            this.comboBoxSelectToShow.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectToShow_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboBoxSelectToQuery);
            this.tabPage2.Controls.Add(this.buttonQuery);
            this.tabPage2.Controls.Add(this.dateTimePickerEnd);
            this.tabPage2.Controls.Add(this.dateTimePickerBegin);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.zedGraphControlHisHumi);
            this.tabPage2.Controls.Add(this.zedGraphControlHisTemp);
            this.tabPage2.Controls.Add(this.listViewHistoryData);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1555, 855);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "历史数据";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "微孔参数号:";
            // 
            // comboBoxSelectToQuery
            // 
            this.comboBoxSelectToQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectToQuery.FormattingEnabled = true;
            this.comboBoxSelectToQuery.Location = new System.Drawing.Point(118, 19);
            this.comboBoxSelectToQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSelectToQuery.Name = "comboBoxSelectToQuery";
            this.comboBoxSelectToQuery.Size = new System.Drawing.Size(86, 26);
            this.comboBoxSelectToQuery.TabIndex = 15;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(858, 17);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(112, 35);
            this.buttonQuery.TabIndex = 13;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(586, 19);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(248, 28);
            this.dateTimePickerEnd.TabIndex = 12;
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Location = new System.Drawing.Point(274, 19);
            this.dateTimePickerBegin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(248, 28);
            this.dateTimePickerBegin.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "至";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "时间:";
            // 
            // zedGraphControlHisHumi
            // 
            this.zedGraphControlHisHumi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControlHisHumi.Location = new System.Drawing.Point(1012, 356);
            this.zedGraphControlHisHumi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.zedGraphControlHisHumi.Name = "zedGraphControlHisHumi";
            this.zedGraphControlHisHumi.ScrollGrace = 0D;
            this.zedGraphControlHisHumi.ScrollMaxX = 0D;
            this.zedGraphControlHisHumi.ScrollMaxY = 0D;
            this.zedGraphControlHisHumi.ScrollMaxY2 = 0D;
            this.zedGraphControlHisHumi.ScrollMinX = 0D;
            this.zedGraphControlHisHumi.ScrollMinY = 0D;
            this.zedGraphControlHisHumi.ScrollMinY2 = 0D;
            this.zedGraphControlHisHumi.Size = new System.Drawing.Size(292, 282);
            this.zedGraphControlHisHumi.TabIndex = 9;
            this.zedGraphControlHisHumi.Visible = false;
            // 
            // zedGraphControlHisTemp
            // 
            this.zedGraphControlHisTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControlHisTemp.Location = new System.Drawing.Point(1012, 85);
            this.zedGraphControlHisTemp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.zedGraphControlHisTemp.Name = "zedGraphControlHisTemp";
            this.zedGraphControlHisTemp.ScrollGrace = 0D;
            this.zedGraphControlHisTemp.ScrollMaxX = 0D;
            this.zedGraphControlHisTemp.ScrollMaxY = 0D;
            this.zedGraphControlHisTemp.ScrollMaxY2 = 0D;
            this.zedGraphControlHisTemp.ScrollMinX = 0D;
            this.zedGraphControlHisTemp.ScrollMinY = 0D;
            this.zedGraphControlHisTemp.ScrollMinY2 = 0D;
            this.zedGraphControlHisTemp.Size = new System.Drawing.Size(292, 245);
            this.zedGraphControlHisTemp.TabIndex = 10;
            this.zedGraphControlHisTemp.Visible = false;
            // 
            // listViewHistoryData
            // 
            this.listViewHistoryData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewHistoryData.HideSelection = false;
            this.listViewHistoryData.Location = new System.Drawing.Point(8, 61);
            this.listViewHistoryData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewHistoryData.Name = "listViewHistoryData";
            this.listViewHistoryData.Size = new System.Drawing.Size(894, 765);
            this.listViewHistoryData.TabIndex = 8;
            this.listViewHistoryData.UseCompatibleStateImageBehavior = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 899);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "光设";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPortList;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDataRate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ZedGraph.ZedGraphControl zedGraphControlHumidity;
        private ZedGraph.ZedGraphControl zedGraphControlTemperature;
        public System.Windows.Forms.ListView listViewDataDisplay;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl zedGraphControlHisHumi;
        private ZedGraph.ZedGraphControl zedGraphControlHisTemp;
        public System.Windows.Forms.ListView listViewHistoryData;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSelectToShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSelectToQuery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label29;
    }
}

