using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using ZedGraph;
using System.Data.OleDb;
using ADOX;


namespace DataDisplay
{
    public partial class FormMain : Form
    {
        delegate void DataInputDelegate(byte[] data, int lenth);

        private DataInputDelegate delegateDataInput = null;
        private PointPairList pointPairListTemperature = new PointPairList();
        private PointPairList pointPairListHumidity = new PointPairList();
        private PointPairList pointPairListHisTemp = new PointPairList();
        private PointPairList pointPairListHisHumi = new PointPairList();
        private List<int> listIDs = new List<int>();
        private int recvCount = 0;
        private OleDbConnection dbConnection = null;
        public int wan = 0;
        public int wanc = 0;

        public int wanl = 0;
        public string recver;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           // System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            delegateDataInput = new DataInputDelegate(this.serialPortDataInput);

            for (int port = 1; port <= 255; port++)
            {
                comboBoxPortList.Items.Add("COM" + port.ToString());
            }

            string[] stringDataRate = new string[6]
            {
                "9600",
                "14400",
                "19200",
                "38400",
                "57600",
                "115200",
            };

            foreach (string s in stringDataRate)
            {
                comboBoxDataRate.Items.Add(s);
            }

            comboBoxPortList.SelectedIndex = 0;
            comboBoxDataRate.SelectedIndex = 0;


            listViewDataDisplay.Clear();
            listViewDataDisplay.View = System.Windows.Forms.View.Details;
            listViewDataDisplay.FullRowSelect = true;
            listViewDataDisplay.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewDataDisplay.GridLines = true;

            listViewDataDisplay.Columns.Add("序号", 40, HorizontalAlignment.Center);
            listViewDataDisplay.Columns.Add("微孔参数号", 60, HorizontalAlignment.Center);
            listViewDataDisplay.Columns.Add("微孔直径", 50, HorizontalAlignment.Center);
            listViewDataDisplay.Columns.Add("激光光强", 50, HorizontalAlignment.Center);
            listViewDataDisplay.Columns.Add("时间", 130, HorizontalAlignment.Center);

            listViewHistoryData.Clear();
            listViewHistoryData.View = System.Windows.Forms.View.Details;
            listViewHistoryData.FullRowSelect = true;
            listViewHistoryData.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewHistoryData.GridLines = true;

            listViewHistoryData.Columns.Add("序号", 40, HorizontalAlignment.Center);
            listViewHistoryData.Columns.Add("微孔参数号", 60, HorizontalAlignment.Center);
            listViewHistoryData.Columns.Add("微孔直径", 50, HorizontalAlignment.Center);
            listViewHistoryData.Columns.Add("激光光强", 50, HorizontalAlignment.Center);
            listViewHistoryData.Columns.Add("时间", 130, HorizontalAlignment.Center);

            this.zedGraphControlTemperature.GraphPane.Title.Text = "微孔参数曲线";
            this.zedGraphControlTemperature.GraphPane.XAxis.Title.Text = "微孔直径";
            this.zedGraphControlTemperature.GraphPane.YAxis.Title.Text = "激光光强";
            this.zedGraphControlTemperature.GraphPane.XAxis.MinorGrid.IsVisible = true;
            this.zedGraphControlTemperature.GraphPane.YAxis.MinorGrid.IsVisible = true;
         //   this.zedGraphControlTemperature.GraphPane.XAxis.MajorGrid.IsVisible= true;
          //  this.zedGraphControlTemperature.GraphPane.YAxis.MajorGrid.IsVisible = true;

            this.zedGraphControlTemperature.GraphPane.XAxis.Scale.Min = 0;
            this.zedGraphControlTemperature.GraphPane.XAxis.Scale.Max = 128;

            this.zedGraphControlTemperature.GraphPane.YAxis.Scale.Min =0;
            this.zedGraphControlTemperature.GraphPane.YAxis.Scale.Max =255;


            this.zedGraphControlHumidity.GraphPane.Title.Text = "激光光强曲线";
            this.zedGraphControlHumidity.GraphPane.XAxis.Title.Text = "时间";
            this.zedGraphControlHumidity.GraphPane.YAxis.Title.Text = "激光光强值";

       //     this.zedGraphControlTemperature.GraphPane.XAxis.Type = ZedGraph.AxisType.DateAsOrdinal;
       //     this.zedGraphControlTemperature.GraphPane.XAxis.Scale.MajorUnit = DateUnit.Millisecond;
        //    this.zedGraphControlTemperature.GraphPane.XAxis.Scale.Format = "HH:mm:ss";

            this.zedGraphControlHumidity.GraphPane.XAxis.Type = ZedGraph.AxisType.DateAsOrdinal;
            this.zedGraphControlHumidity.GraphPane.XAxis.Scale.MajorUnit = DateUnit.Millisecond;
            this.zedGraphControlHumidity.GraphPane.XAxis.Scale.Format = "HH:mm:ss";

            this.zedGraphControlHisTemp.GraphPane.Title.Text = "微孔直径曲线";
            this.zedGraphControlHisTemp.GraphPane.XAxis.Title.Text = "时间";
            this.zedGraphControlHisTemp.GraphPane.YAxis.Title.Text = "微孔直径值";

            this.zedGraphControlHisHumi.GraphPane.Title.Text = "激光光强曲线";
            this.zedGraphControlHisHumi.GraphPane.XAxis.Title.Text = "时间";
            this.zedGraphControlHisHumi.GraphPane.YAxis.Title.Text = "激光光强值";

            this.zedGraphControlHisTemp.GraphPane.XAxis.Type = ZedGraph.AxisType.DateAsOrdinal;
            this.zedGraphControlHisTemp.GraphPane.XAxis.Scale.MajorUnit = DateUnit.Millisecond;
            this.zedGraphControlHisTemp.GraphPane.XAxis.Scale.Format = "HH:mm:ss";

            this.zedGraphControlHisHumi.GraphPane.XAxis.Type = ZedGraph.AxisType.DateAsOrdinal;
            this.zedGraphControlHisHumi.GraphPane.XAxis.Scale.MajorUnit = DateUnit.Millisecond;
            this.zedGraphControlHisHumi.GraphPane.XAxis.Scale.Format = "HH:mm:ss";

            /*           for (int i = 0; i < 100; i++)
                       {
                           pointPairListTemperature.Add((double)new XDate(DateTime.Now), 0);
                           pointPairListHumidity.Add((double)new XDate(DateTime.Now), 0);
                       }*/

       /*     double[] x = new double[1];
            double[] y = new double[1];
            x[0] = 1.2;
            y[0] = 3.3;
            pointPairListTemperature.Add(x, y);
            this.zedGraphControlTemperature.GraphPane.AddCurve("坐标", pointPairListTemperature, Color.Red, SymbolType.Square);
            zedGraphControlTemperature.AxisChange();
            zedGraphControlTemperature.Invalidate();*/



          //  zedGraphControlHumidity.Refresh();
          //  zedGraphControlHisTemp.AxisChange();
          //  zedGraphControlTemperature.Refresh();

          //  zedGraphControlHisHumi.AxisChange();
          //  zedGraphControlHumidity.Refresh();
           
    //        this.zedGraphControlTemperature.GraphPane.AddCurve("微孔直径", pointPairListTemperature, Color.Red, SymbolType.None);
            this.zedGraphControlHumidity.GraphPane.AddCurve("激光光强", pointPairListHumidity, Color.Blue, SymbolType.None);

            this.zedGraphControlHisTemp.GraphPane.AddCurve("微孔直径", pointPairListHisTemp, Color.Red, SymbolType.None);
            this.zedGraphControlHisHumi.GraphPane.AddCurve("激光光强", pointPairListHisHumi, Color.Blue, SymbolType.None);

            

            if (!File.Exists(Application.StartupPath + "\\Data.mdb"))
            {
                Catalog catalog = new Catalog();
                catalog.Create("Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\Data.mdb;Jet OLEDB:Engine Type=5");

                string stringConnention = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\Data.mdb";

                dbConnection = new OleDbConnection(stringConnention);
                dbConnection.Open();

                string stringSql = "CREATE TABLE HM (ID integer, Temperature double, Humidity double, InsertTime Datetime)";

                OleDbCommand command = new OleDbCommand(stringSql, dbConnection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
               // dbConnection.Close();
            }
            else
            {
                string stringConnention = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\Data.mdb";

                dbConnection = new OleDbConnection(stringConnention);
                dbConnection.Open();
            }

            dateTimePickerBegin.Format = DateTimePickerFormat.Custom;
            dateTimePickerBegin.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            dateTimePickerBegin.CustomFormat = dateTimePickerBegin.CustomFormat;

            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            dateTimePickerEnd.CustomFormat = dateTimePickerEnd.CustomFormat;

            listIDs.Clear();
        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if ("打开" == buttonOpenPort.Text)
                {
                    string portName = "COM" + (comboBoxPortList.SelectedIndex + 1).ToString();

                    if (!serialPort.IsOpen)
                    {
                        serialPort.BaudRate = int.Parse(comboBoxDataRate.SelectedItem.ToString());
                        serialPort.DataBits = 8;
                        serialPort.PortName = portName;

                        serialPort.Open();

                        if (serialPort.IsOpen)
                        {
                            buttonOpenPort.Text = "关闭";
                        }
                    }
                }
                else
                {
                    if (serialPort.IsOpen)
                    {
                        serialPort.Close();
                        buttonOpenPort.Text = "打开";
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(20);
            byte[] readBuffer;

            if (serialPort.IsOpen)
            {
                try
                {
                    readBuffer = new byte[serialPort.BytesToRead];
                    serialPort.Read(readBuffer, 0, serialPort.BytesToRead);
                }
                catch (Exception ex)
                {
                    return;
                }

                this.Invoke(delegateDataInput, readBuffer, serialPort.BytesToRead);
                //delegateDataInput.BeginInvoke(readBuffer, serialPort.BytesToRead, null, null);             
            }    
        }
        public static float ConvertHexToFloat(string hexString)
        {
            // 将16进制字符串转换为字节数组
            byte[] bytes = new byte[4];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            // 将字节数组转换为float
            float result = BitConverter.ToSingle(bytes, 0);
            return result;
        }
        private void serialPortDataInput(byte[] data, int lenth)
        {
            string resulty;
            int i;
            int endIndex;
            int wancom = 0;
            ushort combined;
            double[] x = new double[128];
            double[] y = new double[128];
            try
            {
                string input = Encoding.Default.GetString(data);
                int length = input.Length;
                if((data[0]==0xAA))
                {
                    switch (data[1])
                    {
                        case 0x02:
                            byte b = data[2];
                            this.textBox7.Text = Convert.ToString(b); ;
                            break;
                        case 0x04:
                            combined = (ushort)((data[2] << 8) | data[3]);
                            float floatValue = (float)(combined/100.0);
                            textBox8.Text = floatValue.ToString(); // 显示float值
                            break;
                        case 0x05:
                            combined = (ushort)((data[2] << 8) | data[3]);
                            textBox9.Text = combined.ToString(); // 显示float值
                            break;
                        case 0x06:
                            combined = (ushort)((data[2] << 8) | data[3]);
                            textBox1.Text = combined.ToString(); // 显示float值
                            break;
                        case 0x07:
                            combined = (ushort)((data[2] << 8) | data[3]);
                            textBox2.Text = combined.ToString(); // 显示float值
                            break;
                        case 0x09:
                            combined = (ushort)((data[2] << 8) | data[3]);
                            textBox6.Text = combined.ToString(); // 显示float值
                            break;
                        case 0x0A:
                            combined = (ushort)((data[2] << 8) | data[3]);
                            textBox5.Text = combined.ToString(); // 显示float值
                            break;
                        default:
                            // 执行默认代码块
                            break;
                    }
                }
                if (input[0] == '*')
                {
                    if (input[1] == 'L')
                    {
                        if (length == 272)
                        {
                            wanc = 0;
                            wan = 1;
                            recver = input;
                        }
                        else
                        {
                            wanc = 1;
                            wanl = length;
                            recver = input;
                        }
                    }
                    else if (input[1] == 'A')
                    {
                        this.textBox7.Text="32";
                    }
                }
                else
                {
                    if (wanc == 1)
                    {

                        bool containsChar = input.Contains('#');
                        if (containsChar)
                        {

                            endIndex = input.IndexOf('#');
                            resulty = input.Substring(0, endIndex);
                            recver = recver + resulty;
                            wanc = 0;
                            wan = 1;
                        }
                    }
                    else
                    {
                        if (input[0] == '$') 
                            wancom = 1;
                    }  
                }
                if (wan == 1)
                {
                    wan = 0;
                    wanc = 0;
                    for (i = 0; i < 128; i++)
                    {
                        x[i] = i;

                    }
                    for (i = 0; i < 128; i++)
                    {
                        resulty = recver.Substring(11 + i * 2, 2);
                        y[i] = Convert.ToInt32(resulty, 16); //FF为被转值
                    }

                    this.zedGraphControlTemperature.GraphPane.CurveList.Clear();

                    this.zedGraphControlTemperature.GraphPane.GraphObjList.Clear();

                    pointPairListTemperature.Clear();


                    zedGraphControlTemperature.AxisChange();
                    zedGraphControlTemperature.Refresh();

                    //     x[0] = humidity;
                    //      y[0] = temperature;
                    pointPairListTemperature.Add(x, y);
                    this.zedGraphControlTemperature.GraphPane.AddCurve("坐标", pointPairListTemperature, Color.Red, SymbolType.Plus);
                    zedGraphControlTemperature.AxisChange();
                    zedGraphControlTemperature.Invalidate();
                }
                if (wancom == 1)
                {
                    //       int startIndex = input.IndexOf('*') +1; // 找到'x'的位置并加1跳过'x'
                    resulty = input.Substring(11,2);
                    float temperature = Convert.ToInt32(resulty, 16); //FF为被转值
                    float humidity = Convert.ToInt32(resulty, 16);

                    int id = 1;
                    int recvdataCount = this.listViewDataDisplay.Items.Count;



                    listViewDataDisplay.Items.Add((recvCount + 1).ToString(), recvdataCount);
                    listViewDataDisplay.Items[recvdataCount].SubItems.Add(id.ToString());
                    listViewDataDisplay.Items[recvdataCount].SubItems.Add(humidity.ToString());
                    listViewDataDisplay.Items[recvdataCount].SubItems.Add(temperature.ToString());
                    listViewDataDisplay.Items[recvdataCount].SubItems.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    recvCount++;

                    listViewDataDisplay.EnsureVisible(listViewDataDisplay.Items.Count - 1);

                    int findId = listIDs.Find(search =>
                    {
                        if (id == search)
                            return true;
                        else
                            return false;
                    });

                    /*ListIDs中没有这个微孔参数号*/
                    if (id != findId)
                    {
                        listIDs.Add(id);
                        string stringSelect = comboBoxSelectToShow.Text;

                        comboBoxSelectToShow.Items.Clear();
                        int[] array = listIDs.ToArray();
                        object[] obj = (object[])System.Collections.ArrayList.Adapter(array).ToArray(typeof(object));
                        comboBoxSelectToShow.Items.AddRange(obj);

                        if (comboBoxSelectToShow.Items.Count == 1)
                        {
                            comboBoxSelectToShow.SelectedIndex = 0;
                        }
                        else
                        {
                            comboBoxSelectToShow.Text = stringSelect;
                        }
                    }


                    string stringSql = string.Format("INSERT INTO HM VALUES({0}, {1}, {2}, #{3}#)",
                                                     listViewDataDisplay.Items[recvdataCount].SubItems[1].Text,
                                                     listViewDataDisplay.Items[recvdataCount].SubItems[2].Text,
                                                     listViewDataDisplay.Items[recvdataCount].SubItems[3].Text,
                                                     listViewDataDisplay.Items[recvdataCount].SubItems[4].Text);
                    OleDbCommand command = new OleDbCommand(stringSql, dbConnection);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //dbConnection.Close();

                    /*删除太多的记录，防止UI溢出*/
                    // if (listViewDataDisplay.Items.Count > 500)
                    //     listViewDataDisplay.Items.RemoveAt(0);

                }

            }
            catch
            {

            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
           // this.AdjustControlLocationAndSize();
        }

        private void AdjustControlLocationAndSize()
        {
        /*    this.zedGraphControlTemperature.Size = new System.Drawing.Size(this.zedGraphControlTemperature.Size.Width,
                            this.listViewDataDisplay.Size.Height / 2);

            this.zedGraphControlHumidity.Size = new System.Drawing.Size(this.zedGraphControlHumidity.Size.Width,
                this.listViewDataDisplay.Size.Height / 2);

            this.zedGraphControlHumidity.Location =
                new Point(this.zedGraphControlHumidity.Location.X,
                          this.zedGraphControlTemperature.Location.Y + this.zedGraphControlTemperature.Size.Height + 2);

            this.zedGraphControlHisTemp.Size = new System.Drawing.Size(this.zedGraphControlHisTemp.Size.Width,
                this.listViewHistoryData.Size.Height / 2);

            this.zedGraphControlHisHumi.Size = new System.Drawing.Size(this.zedGraphControlHisHumi.Size.Width,
                this.listViewHistoryData.Size.Height / 2);

            this.zedGraphControlHisHumi.Location =
                new Point(this.zedGraphControlHisHumi.Location.X,
                          this.zedGraphControlHisTemp.Location.Y + this.zedGraphControlHisTemp.Size.Height + 2);*/
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
//             string stringConnention = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\Data.mdb";
// 
//             OleDbConnection dbConnection = new OleDbConnection(stringConnention);
//             dbConnection.Open();
            string stringSql = string.Format("SELECT * FROM HM WHERE InsertTime BETWEEN #{0}# AND #{1}#",
                                                             dateTimePickerBegin.Value.ToString("yyyy/MM/dd HH:mm:ss"),
                                                             dateTimePickerEnd.Value.ToString("yyyy/MM/dd HH:mm:ss"));
            if (comboBoxSelectToQuery.Text != "")
            {
                stringSql = string.Format("SELECT * FROM (SELECT * FROM HM WHERE InsertTime BETWEEN #{0}# AND #{1}#) TCG WHERE ID = {2}",
                                                             dateTimePickerBegin.Value.ToString("yyyy/MM/dd HH:mm:ss"),
                                                             dateTimePickerEnd.Value.ToString("yyyy/MM/dd HH:mm:ss"),
                                                             comboBoxSelectToQuery.Text);
            }
            
            OleDbCommand command = new OleDbCommand(stringSql, dbConnection);
            try
            {
                OleDbDataReader reader =  command.ExecuteReader();

                listViewHistoryData.Clear();
                listViewHistoryData.Columns.Add("序号", 40, HorizontalAlignment.Center);
                listViewHistoryData.Columns.Add("微孔参数号", 60, HorizontalAlignment.Center);
                listViewHistoryData.Columns.Add("微孔直径", 50, HorizontalAlignment.Center);
                listViewHistoryData.Columns.Add("激光光强", 50, HorizontalAlignment.Center);
                listViewHistoryData.Columns.Add("时间", 130, HorizontalAlignment.Center);

                pointPairListHisTemp.Clear();
                pointPairListHisHumi.Clear();

                int idx = listViewHistoryData.Items.Count;

                while (reader.Read())
                {
                    listViewHistoryData.Items.Add((idx + 1).ToString(), idx);
                    listViewHistoryData.Items[idx].SubItems.Add(reader[0].ToString());
                    listViewHistoryData.Items[idx].SubItems.Add(reader[1].ToString());
                    listViewHistoryData.Items[idx].SubItems.Add(reader[2].ToString());
                    listViewHistoryData.Items[idx].SubItems.Add(reader[3].ToString());

                    double x = (double)new XDate(DateTime.Parse(reader[3].ToString()));
                    pointPairListHisTemp.Add(x, double.Parse(reader[1].ToString()));
                    pointPairListHisHumi.Add(x, double.Parse(reader[2].ToString()));

                    idx++;
                }

                zedGraphControlHisTemp.AxisChange();
                zedGraphControlHisTemp.Refresh();

                zedGraphControlHisHumi.AxisChange();
                zedGraphControlHisHumi.Refresh();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          //  dbConnection.Close();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
           this.AdjustControlLocationAndSize();

           if (1 == tabControl1.SelectedIndex)
           {
//                string stringConnention = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\Data.mdb";
// 
//                OleDbConnection dbConnection = new OleDbConnection(stringConnention);
//                dbConnection.Open();


               string stringSql = "SELECT DISTINCT ID FROM HM";
               OleDbCommand command = new OleDbCommand(stringSql, dbConnection);
               try
               {
                   OleDbDataReader reader = command.ExecuteReader();

                   string stringSelect = comboBoxSelectToQuery.Text;

                   comboBoxSelectToQuery.Items.Clear();

                   while (reader.Read())
                   {
                       comboBoxSelectToQuery.Items.Add(reader[0].ToString());
                   }

                   if (comboBoxSelectToQuery.Items.Count == 1)
                   {
                       comboBoxSelectToQuery.SelectedIndex = 0;
                   }
                   else
                   {
                       comboBoxSelectToQuery.Text = stringSelect;
                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }

               //dbConnection.Close();
           }
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        //    this.AdjustControlLocationAndSize();  
        }

        private void listViewDataDisplay_Click(object sender, EventArgs e)
        {
        //    this.AdjustControlLocationAndSize();
        }

        private void comboBoxSelectToShow_SelectedIndexChanged(object sender, EventArgs e)
        {
           // pointPairListTemperature.Clear();
          // pointPairListHumidity.Clear();

            for (int i = 0; i < 100; i++)
            {
           //     pointPairListTemperature.Add((double)new XDate(DateTime.Now), 0);
           //     pointPairListHumidity.Add((double)new XDate(DateTime.Now), 0);
            }

            zedGraphControlHisTemp.AxisChange();
            zedGraphControlTemperature.Refresh();

            zedGraphControlHisHumi.AxisChange();
            zedGraphControlHumidity.Refresh();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                dbConnection.Close();
            }
            catch
            {

            }
        }

        private void zedGraphControlHumidity_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 要发送的16进制数据
            byte[] dataToSend = new byte[] { 0xAA, 0x01, 0x00, 0xBB };
            string str = this.textBox7.Text;
            int number = int.Parse(str);
            byte byteValue = (byte)number;
            dataToSend[2] = byteValue;
            // 写入串口
            serialPort.Write(dataToSend, 0, dataToSend.Length);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            // 要发送的16进制数据
            byte[] dataToSend = new byte[] { 0xAA, 0x03, 0x00, 0x00, 0xBB };
            string str = this.textBox8.Text;
            float bshu = float.Parse(str)*100+1;
            int number = (int)bshu;
            byte byte1 = (byte)(number>>8);
            byte byte2 = (byte)number;
            dataToSend[2] = byte1;
            dataToSend[3] = byte2;
            // 写入串口
            serialPort.Write(dataToSend, 0, dataToSend.Length);





        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 要发送的16进制数据
            byte[] dataToSend = new byte[] { 0xAA, 0x02, 0x00, 0xBB };
            serialPort.Write(dataToSend, 0, dataToSend.Length);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // 要发送的16进制数据
            byte[] dataToSend = new byte[] { 0xAA, 0x04, 0x00, 0x00, 0xBB };
            serialPort.Write(dataToSend, 0, dataToSend.Length);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] dataToSend = new byte[] { 0xAA, 0x05, 0x00, 0x00, 0xBB };
            serialPort.Write(dataToSend, 0, dataToSend.Length);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] dataToSend = new byte[] { 0xAA, 0x06, 0x00, 0x00, 0xBB };
            serialPort.Write(dataToSend, 0, dataToSend.Length);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] dataToSend = new byte[] { 0xAA, 0x07, 0x00, 0x00, 0xBB };
            serialPort.Write(dataToSend, 0, dataToSend.Length);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // byte[] dataToSend = new byte[] { 0xAA, 0x08, 0x00, 0x00, 0xBB };
            // serialPort.Write(dataToSend, 0, dataToSend.Length);

            string str1 = this.textBox1.Text;
            string str2 = this.textBox2.Text;
            double number = int.Parse(str1) - int.Parse(str2);
            number = number / 2.0;
            double sideA = number; // 第一直角边长度
            double sideB = int.Parse(this.textBox10.Text); // 第二直角边长度
            // 计算斜角角度
            double angleInDegrees = Math.Atan2(sideB, sideA) * (180.0 / Math.PI);
            double roundedValue = Math.Round(angleInDegrees, 2);
            textBox3.Text = roundedValue.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte[] dataToSend = new byte[] { 0xAA, 0x09, 0x00, 0x00, 0xBB };
            serialPort.Write(dataToSend, 0, dataToSend.Length);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte[] dataToSend = new byte[] { 0xAA, 0x0A, 0x00, 0x00, 0xBB };
            serialPort.Write(dataToSend, 0, dataToSend.Length);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //    byte[] dataToSend = new byte[] { 0xAA, 0x0B, 0x00, 0x00, 0xBB };
            //   serialPort.Write(dataToSend, 0, dataToSend.Length);
            string str1 = this.textBox6.Text;
            string str2 = this.textBox5.Text;
            int number = int.Parse(str1)- int.Parse(str2);
            textBox4.Text = number.ToString();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
