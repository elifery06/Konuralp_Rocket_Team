namespace Konuralp_Rocket_Team
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPortRefresh = new System.Windows.Forms.Button();
            this.ComClose2 = new System.Windows.Forms.Button();
            this.ComPorts2 = new System.Windows.Forms.ComboBox();
            this.ComPort2Status = new System.Windows.Forms.ProgressBar();
            this.ComOpen2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ComPortCloseButton = new System.Windows.Forms.Button();
            this.ComPorts1 = new System.Windows.Forms.ComboBox();
            this.ComPort1Status = new System.Windows.Forms.ProgressBar();
            this.ComPortOpenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblLongtitude = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblPressureBmp = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblPressureLps = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblFilterAltitude = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblGZ = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblGX = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblGY = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblAZ = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblAY = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblAX = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnPortRefresh);
            this.groupBox1.Controls.Add(this.ComClose2);
            this.groupBox1.Controls.Add(this.ComPorts2);
            this.groupBox1.Controls.Add(this.ComPort2Status);
            this.groupBox1.Controls.Add(this.ComOpen2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ComPortCloseButton);
            this.groupBox1.Controls.Add(this.ComPorts1);
            this.groupBox1.Controls.Add(this.ComPort1Status);
            this.groupBox1.Controls.Add(this.ComPortOpenButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnPortRefresh
            // 
            this.btnPortRefresh.BackColor = System.Drawing.Color.Goldenrod;
            resources.ApplyResources(this.btnPortRefresh, "btnPortRefresh");
            this.btnPortRefresh.Name = "btnPortRefresh";
            this.btnPortRefresh.UseVisualStyleBackColor = false;
            this.btnPortRefresh.Click += new System.EventHandler(this.btnPortRefresh_Click);
            // 
            // ComClose2
            // 
            resources.ApplyResources(this.ComClose2, "ComClose2");
            this.ComClose2.Name = "ComClose2";
            this.ComClose2.UseVisualStyleBackColor = true;
            this.ComClose2.Click += new System.EventHandler(this.ComClose2_Click);
            // 
            // ComPorts2
            // 
            resources.ApplyResources(this.ComPorts2, "ComPorts2");
            this.ComPorts2.FormattingEnabled = true;
            this.ComPorts2.Name = "ComPorts2";
            // 
            // ComPort2Status
            // 
            resources.ApplyResources(this.ComPort2Status, "ComPort2Status");
            this.ComPort2Status.Name = "ComPort2Status";
            this.ComPort2Status.Tag = "";
            // 
            // ComOpen2
            // 
            resources.ApplyResources(this.ComOpen2, "ComOpen2");
            this.ComOpen2.Name = "ComOpen2";
            this.ComOpen2.UseVisualStyleBackColor = true;
            this.ComOpen2.Click += new System.EventHandler(this.ComOpen2_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // ComPortCloseButton
            // 
            resources.ApplyResources(this.ComPortCloseButton, "ComPortCloseButton");
            this.ComPortCloseButton.Name = "ComPortCloseButton";
            this.ComPortCloseButton.UseVisualStyleBackColor = true;
            this.ComPortCloseButton.Click += new System.EventHandler(this.ComPortCloseButton_Click);
            // 
            // ComPorts1
            // 
            resources.ApplyResources(this.ComPorts1, "ComPorts1");
            this.ComPorts1.FormattingEnabled = true;
            this.ComPorts1.Name = "ComPorts1";
            // 
            // ComPort1Status
            // 
            resources.ApplyResources(this.ComPort1Status, "ComPort1Status");
            this.ComPort1Status.Name = "ComPort1Status";
            this.ComPort1Status.Tag = "";
            // 
            // ComPortOpenButton
            // 
            resources.ApplyResources(this.ComPortOpenButton, "ComPortOpenButton");
            this.ComPortOpenButton.Name = "ComPortOpenButton";
            this.ComPortOpenButton.UseVisualStyleBackColor = true;
            this.ComPortOpenButton.Click += new System.EventHandler(this.ComPortOpenButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblLatitude);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.lblLongtitude);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.lblPressureBmp);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.lblPressureLps);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.lblFilterAltitude);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.lblRoll);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.lblGZ);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.lblGX);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.lblGY);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.lblAZ);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.lblAY);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.lblAX);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.lblPitch);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.lblAltitude);
            this.tabPage1.Controls.Add(this.label3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblLatitude
            // 
            resources.ApplyResources(this.lblLatitude, "lblLatitude");
            this.lblLatitude.Name = "lblLatitude";
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.Name = "label37";
            // 
            // lblLongtitude
            // 
            resources.ApplyResources(this.lblLongtitude, "lblLongtitude");
            this.lblLongtitude.Name = "lblLongtitude";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // lblPressureBmp
            // 
            resources.ApplyResources(this.lblPressureBmp, "lblPressureBmp");
            this.lblPressureBmp.Name = "lblPressureBmp";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // lblPressureLps
            // 
            resources.ApplyResources(this.lblPressureLps, "lblPressureLps");
            this.lblPressureLps.Name = "lblPressureLps";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // lblFilterAltitude
            // 
            resources.ApplyResources(this.lblFilterAltitude, "lblFilterAltitude");
            this.lblFilterAltitude.Name = "lblFilterAltitude";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // lblRoll
            // 
            resources.ApplyResources(this.lblRoll, "lblRoll");
            this.lblRoll.Name = "lblRoll";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // lblGZ
            // 
            resources.ApplyResources(this.lblGZ, "lblGZ");
            this.lblGZ.Name = "lblGZ";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // lblGX
            // 
            resources.ApplyResources(this.lblGX, "lblGX");
            this.lblGX.Name = "lblGX";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // lblGY
            // 
            resources.ApplyResources(this.lblGY, "lblGY");
            this.lblGY.Name = "lblGY";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // lblAZ
            // 
            resources.ApplyResources(this.lblAZ, "lblAZ");
            this.lblAZ.Name = "lblAZ";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // lblAY
            // 
            resources.ApplyResources(this.lblAY, "lblAY");
            this.lblAY.Name = "lblAY";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // lblAX
            // 
            resources.ApplyResources(this.lblAX, "lblAX");
            this.lblAX.Name = "lblAX";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // lblPitch
            // 
            resources.ApplyResources(this.lblPitch, "lblPitch");
            this.lblPitch.Name = "lblPitch";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // lblAltitude
            // 
            resources.ApplyResources(this.lblAltitude, "lblAltitude");
            this.lblAltitude.Name = "lblAltitude";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gMapControl1);
            this.tabPage2.Controls.Add(this.splitter1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            resources.ApplyResources(this.gMapControl1, "gMapControl1");
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Zoom = 0D;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ComPortCloseButton;
        private System.Windows.Forms.ComboBox ComPorts1;
        private System.Windows.Forms.ProgressBar ComPort1Status;
        private System.Windows.Forms.Button ComPortOpenButton;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblLongtitude;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblPressureBmp;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblPressureLps;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblFilterAltitude;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblGZ;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblGX;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblGY;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblAZ;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblAY;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblAX;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label label13;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button ComClose2;
        private System.Windows.Forms.ComboBox ComPorts2;
        private System.Windows.Forms.ProgressBar ComPort2Status;
        private System.Windows.Forms.Button ComOpen2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPortRefresh;
        private System.Windows.Forms.Splitter splitter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}

