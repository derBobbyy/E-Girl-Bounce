using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Girl_Bounce.Properties;

namespace E_Girl_Bounce
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            Settings.Default.settingsWindowOpen = true;
            domainUpDown1.Text = Settings.Default.Windows;
            windowMoveCB.Checked = Settings.Default.moveWindows;

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.settingsWindowOpen = false;
            this.Close();
        }


        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (Settings.Default.started == true)
            {
                domainUpDown1.Text = Settings.Default.Windows;
            }
            else
            {
                Settings.Default.Windows = domainUpDown1.Text;
            }
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void windowMoveCB_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (Settings.Default.moveWindows == true)
            {
                Settings.Default.moveWindows = false;
            }
            else
            {
                Settings.Default.moveWindows = true;
            }
        }
    }
}
