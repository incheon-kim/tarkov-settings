using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using NvAPIWrapper.Display;
using NvAPIWrapper.DRS;

namespace tarkov_settings
{
    public partial class MainForm : Form
    {
        private ProcessMonitor pMonitor = ProcessMonitor.Instance;
        public MainForm()
        {
            InitializeComponent();

            // Initialize Process Monitor
            pMonitor.Parent = this;
            pMonitor.Add("EscapeFromTarkov");
            pMonitor.Add("KakaoTalk");

            // Initialize Tarkov Setting Panel

            // Initialize NvAPI Controller

            // Initialize Win32 Gamma Control

        }

        public double Brightness
        {
            get=>BrightnessBar.Value/100.0;
            set=>BrightnessBar.Value=(int)value*100;
        }

        public double Contrast
        {
            get=>ContrastBar.Value/100.0;
            set=>ContrastBar.Value=(int)value*100;
        }

        public double Gamma
        {
            get=>GammaBar.Value/100.0;
            set=>GammaBar.Value=(int)value*100;
        }

        public int DVL
        {
            get=>DVLBar.Value;
            set=>DVLBar.Value=value;
        }

        private bool _IsTarkovActive;
        public bool IsTarkovActive
        {
            get => _IsTarkovActive;
            set
            {
                if (value)
                {
                    // revert NvAPI Color, Win32 Gamma Settings
                }
                else
                {
                    // revert NvAPI Color, Win32 Gamma Settings
                }
                _IsTarkovActive = value;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosed(EventArgs e)
        {
            pMonitor.Reset();
            System.Threading.Thread.Sleep(1000);
            base.OnClosed(e);
            Environment.Exit(0);
        }

        #region Control Event Handlers
        private void BrightnessLabel_DoubleClick(object sender, EventArgs e)
        {
            BrightnessBar.Value = 50;
        }

        private void ContrastLabel_Click(object sender, EventArgs e)
        {
            ContrastBar.Value = 50;
        }

        private void GammaLabel_Click(object sender, EventArgs e)
        {
            GammaBar.Value = 100;
        }
        private void DVLLabel_Click(object sender, EventArgs e)
        {
            DVLBar.Value = 0;
        }

        private void BrightnessBar_ValueChanged(object sender, EventArgs e)
        {
            BrightnessText.Text = (BrightnessBar.Value / 100.0).ToString("0.00");
        }

        private void ContrastBar_ValueChanged(object sender, EventArgs e)
        {
            ContrastText.Text = (ContrastBar.Value / 100.0).ToString("0.00");
        }

        private void GammaBar_ValueChanged(object sender, EventArgs e)
        {
            GammaText.Text = (GammaBar.Value / 100.0).ToString("0.00");
        }

        private void DVLBar_ValueChanged(object sender, EventArgs e)
        {
            DVLText.Text = DVLBar.Value.ToString();
        }
        #endregion
        
        public (double, double, double, int) GetColorValue()
        {
            return (
                BrightnessBar.Value / 100.0,
                ContrastBar.Value / 100.0,
                GammaBar.Value / 100.0,
                DVLBar.Value
                );
        }
    }
}
