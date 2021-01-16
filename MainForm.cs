using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private List<ProcessMonitor> pMonitors;
        public MainForm()
        {
            InitializeComponent();

            // Initialize Process Monitor
            pMonitors = new List<ProcessMonitor>();
            pMonitors.Add(new ProcessMonitor(this, "EscapeFromTarkov"));

            // Initialize Tarkov Setting Panel

            // Initialize NvAPI Controller

            // Initialize Win32 Gamma Control

        }

        private bool _IsTarkovExist = false;
        public bool IsTarkovExist
        {
            get => _IsTarkovExist;
            set
            {
                _IsTarkovExist = value;
            }
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

        public string debugText
        {
            get { return debugBox.Text; }
            set { debugBox.Text = value; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TarkovSettingsPanel tarkovSettingsPanel = new TarkovSettingsPanel();
            layoutTablePanel.Controls.Add(tarkovSettingsPanel, 1, 0);
        }
    }
}
