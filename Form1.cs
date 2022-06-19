using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Konuralp_Rocket_Team
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Constants
        //dataFromCom1: Seri Port 1 den gelen veri 
        //dataFromCom2: Seri Port 2 den gelen veri
        string dataFromCom1, dataFromCom2;
        
        //index of değerleri gelen veri içerisindeki değer ayırıcı harflerin tutulduğu değişkenler
        short indexOfAltitude, 
            indexOfLongtitude, 
            indexOfLatitude, 
            indexOfPressureBMP, 
            indexOfPressureLPS, 
            indexOfFilterAltitude, 
            indexOfRoll,
            indexOfPitch,
            indexOfAX,
            indexOfAY,
            indexOfAZ,
            indexOfGX,
            indexOfGY,
            indexOfGZ,
            indexOfEnd;

        //kullanacağımız verileri tuttuğumuz değişkenler
        string altitude, 
            longtitude,
            latitude,
            pressureBMP,
            pressureLPS,
            filterAlitude,
            roll,
            pitch,
            aX,aY,aZ,
            gX,gY,gZ;


        //log defterleri yolları
        string
            com_port_1_log_path = @"..\..\log\debug_log_com_1.txt",
            com_port_2_log_path = @"..\..\log\debug_log_com_2.txt",
            debug_error_log_path = @"..\..\log\debug_error_log.txt";
        #endregion


        private void btnPortRefresh_Click(object sender, EventArgs e)
        {
            getPortNames();
        }
        void getPortNames()
        {
            //Seri Portları okuyarak bunları değişken içerisine atıyoruz
            string[] portNames = SerialPort.GetPortNames();

            //1. Com Port 
            ComPorts1.Items.AddRange(portNames);
            if (portNames.Length != 0) ComPorts1.Text = portNames[0];

            //2. Com Port
            ComPorts2.Items.AddRange(portNames);
            if (portNames.Length > 0) ComPorts2.Text = portNames[1];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getPortNames();

            //Tam olarak anlamadığım bir hata için bu satır kullanılıyor herhangi bir yerde kullanılmıyor.
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        #region Com Port Settings

        #region Com Port Open
        #region Com Port 1
        //Port 1 > Bağlan butonuna basıldığında çalışacak blok
        private void ComPortOpenButton_Click(object sender, EventArgs e)
        {
            ComPortOpen(serialPort1, ComPorts1, ComPort1Status);
        }
        #endregion

        #region Com Port 2
        //Port 2 > Bağlan butonuna basıldığında çalışacak blok
        private void ComOpen2_Click(object sender, EventArgs e)
        {
            ComPortOpen(serialPort2, ComPorts2, ComPort2Status);
        }
        #endregion

        private void ComPortOpen(SerialPort serialPort, ComboBox portBox, ProgressBar comPortStatus)
        {
            //generic bir yapı olması için temel fonksiyon oluşturdum
            //bu fonksiyon sayesinde eğer başka seri port eklenirse generic olarak Port açılacak
            try
            {
                //bize verilen seri port ile combobox ın değerlerini eşitledim ve verilen seri portu açtım
                serialPort.PortName = portBox.Text;
                serialPort.Open();
                comPortStatus.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Bir hatanız var!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                File.AppendAllText(debug_error_log_path, $"{serialPort.PortName} : {err.Message}  |  {DateTime.Now}\n");
            }
        }
        #endregion

        #region Com Port Close
        #region Com Port 1
        //Port 1 > Bağlantıyı Kes butonuna basıldığında çalışacak blok
        private void ComPortCloseButton_Click(object sender, EventArgs e)
        {
            ComPortClose(serialPort1, ComPort1Status);
        }
        #endregion

        #region Com Port 2
        //Port 2 > Bağlantıyı Kes butonuna basıldığında çalışacak blok
        private void ComClose2_Click(object sender, EventArgs e)
        {
            ComPortClose(serialPort2, ComPort2Status);
        }
        #endregion

        //generic bir yapı olması için temel fonksiyon oluşturdum
        //bu fonksiyon sayesinde eğer başka seri port eklenirse generic olarak Port kapanacak
        private void ComPortClose(SerialPort serialPort, ProgressBar comPortStatus)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            else
            {
                MessageBox.Show("Seri port zaten kapalı.", "Seri Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comPortStatus.Value = 0;
        }
        #endregion
        
        #endregion

        #region Data

        #region Data Receive
        #region Data Receive Com 1 
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                //seri port üzerinden veri alıyoruz
                dataFromCom1 = serialPort1.ReadExisting();

                #region Index Of
                //gelecek verilerin başlangıç karakterleri değişkenlere atıldı
                indexOfAltitude = Convert.ToSByte(dataFromCom1.IndexOf('A'));
                indexOfLongtitude = Convert.ToSByte(dataFromCom1.IndexOf('B'));
                indexOfLatitude = Convert.ToSByte(dataFromCom1.IndexOf('C'));
                indexOfPressureBMP = Convert.ToSByte(dataFromCom1.IndexOf('D'));
                indexOfPressureLPS = Convert.ToSByte(dataFromCom1.IndexOf('E'));
                /*indexOfFilterAltitude = Convert.ToSByte(dataFromCom1.IndexOf('F'));
                indexOfRoll = Convert.ToSByte(dataFromCom1.IndexOf('G'));
                indexOfPitch = Convert.ToSByte(dataFromCom1.IndexOf('H'));
                indexOfAX = Convert.ToSByte(dataFromCom1.IndexOf('I'));
                indexOfAY = Convert.ToSByte(dataFromCom1.IndexOf('J'));
                indexOfAZ = Convert.ToSByte(dataFromCom1.IndexOf('K'));
                indexOfGX = Convert.ToSByte(dataFromCom1.IndexOf('L'));
                indexOfGY = Convert.ToSByte(dataFromCom1.IndexOf('M'));
                indexOfGZ = Convert.ToSByte(dataFromCom1.IndexOf('N'));
                indexOfEnd = Convert.ToSByte(dataFromCom1.IndexOf('Z'));*/
                #endregion         

                // verileri logluyoruz
                this.Invoke(new EventHandler(logData));

                // verileri göster methodu çağırıyoruz.
                // bu method içerisinde verilerimizi işleyeceğiz
                this.Invoke(new EventHandler(ShowDataCom1));   
            }
            catch (Exception err)
            {
                File.AppendAllText(debug_error_log_path, $"Com 1 Data Receive : {err.Message}  |  {DateTime.Now}\n");
            }

        }
        #endregion

        #region Data Receive Com 2
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                //seri port üzerinden verileri alıyoruz
                dataFromCom2 = serialPort2.ReadExisting();

                // verileri logluyoruz
                this.Invoke(new EventHandler(logDataCom2));

                // verileri göster methodu çağırıyoruz.
                // bu method içerisinde verilerimizi işleyeceğiz
                this.Invoke(new EventHandler(ShowDataCom2));
            }
            catch (Exception err)
            {
                File.AppendAllText(debug_error_log_path, $"Com 2 Data Receive : {err.Message}  |  {DateTime.Now}\n");
            }
        }


        #endregion
        #endregion

        #region Log Data
        #region Com Port 1 Log
        //Com 1 den gelen verileri yedekliyoruz
        private void logData(object sender, EventArgs e)
        {
            try
            {
                // {com_port_1_log_path} yolundaki belgeye Com 1 den gelen veriyi logluyoruz
                File.AppendAllText(com_port_1_log_path, $"{dataFromCom1}  |  {DateTime.Now}\n");
            }
            catch (Exception err)
            {
                File.AppendAllText(debug_error_log_path, $"Com Port 1 : {err.Message}  |  {DateTime.Now}\n");
                MessageBox.Show($"{err.Message} \n {DateTime.Now}", "Bir hata aldık!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Com Port 2 Log
        private void logDataCom2(object sender, EventArgs e)
        {
            try
            {
                // {com_port_2_log_path} yolundaki belgeye Com 2 den gelen veriyi logluyoruz
                File.AppendAllText(com_port_2_log_path, $"{dataFromCom2}  |  {DateTime.Now}\n");
            }
            catch (Exception err)
            {
                File.AppendAllText(debug_error_log_path, $"Com Port 2 : {err.Message}  |  {DateTime.Now}\n");
                MessageBox.Show($"{err.Message} \n {DateTime.Now}", "Bir hata aldık!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        #endregion

        #region Data Processing
        #region Com Port 1 Processing
        private void ShowDataCom1(object sender, EventArgs e)
        {
            label5.Text = dataFromCom1;
            try
            {
                changedValue();
                //gMapControl1.MapProvider = GMapProviders.GoogleMap;
                //gMapControl1.MinZoom = 10;
                //gMapControl1.MaxZoom = 1000;
                //gMapControl1.Zoom = 15;
                //gMapControl1.Position = new GMap.NET.PointLatLng(
                //    Convert.ToDouble(latitude.Replace('.', ',')), 
                //    Convert.ToDouble(longtitude.Replace('.', ','))
                //);
            }
            catch (Exception err)
            {
                File.AppendAllText(debug_error_log_path, $"Com 1 Show Data : {err.Message}  |  {DateTime.Now}\n");
            }
            /*if (
            //    indexOfAltitude >= 0 &&
            //    indexOfLongtitude > 0 &&
            //    indexOfLatitude > 0 &&
            //    indexOfPressureBMP > 0 &&
            //    indexOfPressureLPS > 0 &&
            //    indexOfFilterAltitude > 0 &&
            //    indexOfRoll > 0 && indexOfPitch > 0 &&
            //    indexOfAX > 0 && indexOfAY > 0 && indexOfAZ > 0 &&
            //    indexOfGX > 0 && indexOfGY > 0 && indexOfGZ > 0)
            {
            //}*/
        }
        void changedValue()
        {
            altitude = dataFromCom1.Substring(indexOfAltitude + 1, (indexOfLongtitude - indexOfAltitude) - 1);
            longtitude = dataFromCom1.Substring(indexOfLongtitude + 1, (indexOfLatitude - indexOfLongtitude) - 1);
            latitude = dataFromCom1.Substring(indexOfLatitude + 1, (indexOfPressureBMP - indexOfLatitude) - 1);
            pressureBMP = dataFromCom1.Substring(indexOfPressureBMP + 1, (indexOfPressureLPS - indexOfPressureBMP) - 1);
            pressureLPS = dataFromCom1.Substring(indexOfPressureLPS + 1, (dataFromCom1.Length - indexOfPressureLPS) - 1);
            //filterAlitude = dataFromCom1.Substring(indexOfFilterAltitude + 1, (indexOfRoll - indexOfFilterAltitude) - 1);
            //roll = dataFromCom1.Substring(indexOfRoll + 1, (indexOfPitch - indexOfRoll) - 1);
            //pitch = dataFromCom1.Substring(indexOfPitch + 1, (indexOfAX - indexOfPitch) - 1);
            //aX = dataFromCom1.Substring(indexOfAX + 1, (indexOfAY - indexOfAX) - 1);
            //aY = dataFromCom1.Substring(indexOfAY + 1, (indexOfAZ - indexOfAY) - 1);
            //aZ = dataFromCom1.Substring(indexOfAZ + 1, (indexOfGX - indexOfAZ) - 1);
            //gX = dataFromCom1.Substring(indexOfGX + 1, (indexOfGY - indexOfGX) - 1);
            //gY = dataFromCom1.Substring(indexOfGY + 1, (indexOfGZ - indexOfGY) - 1);
            //gZ = dataFromCom1.Substring(indexOfGZ + 1, (indexOfEnd - indexOfGZ) - 1);

            //Altitude
            textLenght(altitude, lblAltitude, 3);

            //Longtitude
            textLenght(longtitude, lblLongtitude, 5);

            //Latitude
            textLenght(latitude, lblLatitude, 5);

            //PressureBmp
            textLenght(pressureBMP, lblPressureBmp, 3);

            //PressureLPS
            textLenght(pressureLPS, lblPressureLps, 3);

            //lblFilterAltitude.Text = filterAlitude;
            //lblRoll.Text = roll;
            //lblPitch.Text = pitch;
            //lblAX.Text = aX;
            //lblAY.Text = aY;
            //lblAZ.Text = aZ;
            //lblGX.Text = gX;
            //lblGY.Text = gY;
            //lblGZ.Text = gZ;
        }
        void textLenght(string value, Label label, int charLenght)
        {
            if (value.Length > charLenght)
            {
                label.Text = value.Substring(0, charLenght + 1);
            }
            else if (value.Length <= charLenght)
            {
                label.Text = value;
            }
        }
        #endregion


        #region Com Port 2 Processing
        private void ShowDataCom2(object sender, EventArgs e)
        {
            try
            {
                label6.Text = dataFromCom2;
            }
            catch (Exception err)
            {
                File.AppendAllText(debug_error_log_path, $"Com 2 Show Data : {err.Message}  |  {DateTime.Now}\n");
            }
        }
        #endregion

        #endregion

        #endregion
    }
}
