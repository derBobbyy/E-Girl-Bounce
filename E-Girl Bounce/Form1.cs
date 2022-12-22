﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows;

namespace E_Girl_Bounce
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public SoundPlayer soundPlayer = new SoundPlayer("bin\\assets\\lib\\sounds\\sound1.wav");
        public Window win = new Window();

        public int timer = 0;
        private static readonly Random _random = new Random();

        public Window1 win1 = new Window1();
        public Window2 win2 = new Window2();
        public Window3 win3 = new Window3();
        public Window4 win4 = new Window4();
        public Window5 win5 = new Window5();
        public Window6 win6 = new Window6();
        public Window7 win7 = new Window7();
        public Window8 win8 = new Window8();
        public Window9 win9 = new Window9();
        public Window10 win10 = new Window10();
        public Window11 win11 = new Window11();



        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }
        

        void playSound()
        {
            soundPlayer.PlayLooping();
        }

        void ShowOne()
        {
            int width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            // Win 1
            int x = 1;
            int y = 1;
            x = _random.Next(0, width - win1.Width);
            y = _random.Next(0, height - win1.Height);
            win1.Location = new Point(x, y);
            win1.Show();
        }
        void ShowGirls()
        {
            int width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            int x = 1;
            int y = 1;

            // Win 2
            x = _random.Next(0, width - win2.Width);
            y = _random.Next(0, height - win2.Height);
            win2.Location = new Point(x, y);
            win2.Show();

            // Win 3
            x = _random.Next(0, width - win3.Width);
            y = _random.Next(0, height - win3.Height);
            win3.Location = new Point(x, y);
            win3.Show();

            // Win 4
            x = _random.Next(0, width - win4.Width);
            y = _random.Next(0, height - win4.Height);
            win4.Location = new Point(x, y);
            win4.Show();

            // Win 5
            x = _random.Next(0, width - win5.Width);
            y = _random.Next(0, height - win5.Height);
            win5.Location = new Point(x, y);
            win5.Show();

            // Win 6
            x = _random.Next(0, width - win6.Width);
            y = _random.Next(0, height - win6.Height);
            win6.Location = new Point(x, y);
            win6.Show();

            // Win 7
            x = _random.Next(0, width - win7.Width);
            y = _random.Next(0, height - win7.Height);
            win7.Location = new Point(x, y);
            win7.Show();

            // Win 8
            x = _random.Next(0, width - win8.Width);
            y = _random.Next(0, height - win8.Height);
            win8.Location = new Point(x, y);
            win8.Show();

            // Win 9
            x = _random.Next(0, width - win9.Width);
            y = _random.Next(0, height - win9.Height);
            win9.Location = new Point(x, y);
            win9.Show();

            // Win 10
            x = _random.Next(0, width - win10.Width);
            y = _random.Next(0, height - win10.Height);
            win10.Location = new Point(x, y);
            win10.Show();

            // Win 11
            x = _random.Next(0, width - win11.Width);
            y = _random.Next(0, height - win11.Height);
            win11.Location = new Point(x, y);
            win11.Show();

        }

        

        void CloseAll()
        {
            win1.Close();
            Thread.Sleep(1);
            win2.Close();
            Thread.Sleep(2);
            win3.Close();
            Thread.Sleep(2);
            win4.Close();
            Thread.Sleep(2);
            win5.Close();
            Thread.Sleep(2);
            win6.Close();
            Thread.Sleep(2);
            win7.Close();
            Thread.Sleep(2);
            win8.Close();
            Thread.Sleep(2);
            win9.Close();
            Thread.Sleep(2);
            win10.Close();
            Thread.Sleep(2);
            win11.Close();
            Thread.Sleep(5);
            this.Close();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            playSound();
            timer1.Enabled = true;
            timer1.Start();
            ShowOne();
            this.Visible = false;
            
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            CloseAll();
        }

        void ShowAll()
        {
            ShowGirls();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer += 1;

            if (timer == 11 || timer > 11)
            {
                ShowAll();
                this.Visible = true;
            }

            if (timer == 169 || timer > 169)
            {
                CloseAll();
            }

        }
    }
}
