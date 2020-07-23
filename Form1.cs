using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraAutoClicker
{
    public partial class Form1 : Form
    {
        ReaderWriterLockSlim Clicking = new ReaderWriterLockSlim();

        public bool IsClicking
        {
            get
            {
                Clicking.EnterReadLock();
                bool b = isClicking;
                Clicking.ExitReadLock();
                return b;
            }
            private set
            {
                Clicking.EnterWriteLock();
                isClicking = value;
                Clicking.ExitWriteLock();
            }
        }

        private bool isClicking;

        Random ClickRandomizer = new Random();

        int RandomizationMultiplier = 0;//0 for milliseconds, 1000 for seconds, 60000 for minutes and 3600000 for hours

        ulong ClicksCount = 0;

        ulong ClicksLimit = 0;

        MousePointSelector MousePointSelector;

        KeyboardHook HotKey = new KeyboardHook();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            mouseButtonSelector.SelectedIndex = 0;
            clickTypeSelector.SelectedIndex = 0;
            MousePointSelector = new MousePointSelector(this);
            HotKey.HookedKeys.Add(Keys.Shift);
            HotKey.HookedKeys.Add(Keys.F6);
            HotKey.KeyDown += HotKey_KeyDown;
            HotKey.Hook();
        }

        public void StartClicking()
        {
            timer1.Interval = Convert.ToInt32(millisecondsCounter.Value + (secondsCounter.Value * 1000) + (minutesCounter.Value * 60000) + (hoursCounter.Value * 3600000)) + ClickRandomizer.Next(-Convert.ToInt32(randomizerCount.Value * RandomizationMultiplier), Convert.ToInt32(randomizerCount.Value * RandomizationMultiplier));
            timer1.Start();
            IsClicking = true;
            button1.Enabled = false;
            button3.Enabled = true;
        }

        public void StopClicking()
        {
            timer1.Stop();
            IsClicking = false;
            button1.Enabled = true;
            button3.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton4.Checked)//move the mouse
            {
                MouseOperations.SetCursorPosition(new MouseOperations.MousePoint(Convert.ToInt32(xCoordinateSelector.Value), Convert.ToInt32(yCoordinateSelector.Value)));
            }

            switch(mouseButtonSelector.SelectedIndex)
            {
                case 0://left
                    {
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);

                        if (clickTypeSelector.SelectedIndex == 1)//double click
                        {
                            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
                        }

                        break;
                    }
                case 1://middle
                    {
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleDown);
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleUp);

                        if (clickTypeSelector.SelectedIndex == 1)//double click
                        {
                            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleDown);
                            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleUp);
                        }

                        break;
                    }
                case 2://right
                    {
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.RightDown);
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.RightUp);

                        if (clickTypeSelector.SelectedIndex == 1)//double click
                        {
                            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.RightDown);
                            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.RightUp);
                        }

                        break;
                    }
            }

            ClicksCount++;

            if (ClicksCount >= ClicksLimit && ClicksLimit != 0)
            {
                StopClicking();
            }
            timer1.Interval = Convert.ToInt32(millisecondsCounter.Value + (secondsCounter.Value * 1000) + (minutesCounter.Value * 60000) + (hoursCounter.Value * 3600000)) + ClickRandomizer.Next(-Convert.ToInt32(randomizerCount.Value * RandomizationMultiplier), Convert.ToInt32(randomizerCount.Value * RandomizationMultiplier));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartClicking();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StopClicking();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0://milliseconds
                    {
                        RandomizationMultiplier = 0;
                        break;
                    }
                case 1://seconds
                    {
                        RandomizationMultiplier = 1000;
                        break;
                    }
                case 2://minutes
                    {
                        RandomizationMultiplier = 60000;
                        break;
                    }
                case 3://hours
                    {
                        RandomizationMultiplier = 3600000;
                        break;
                    }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ClicksLimit = Convert.ToUInt64(numericUpDown6.Value);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ClicksLimit = 0;
        }

        private void button0_Click(object sender, EventArgs e)//detect mouse position
        {
            MousePointSelector.ShowDialog();
            MousePointSelector = new MousePointSelector(this);
        }

        private void button2_Click(object sender, EventArgs e)//hotkey settings
        {

        }

        private void button4_Click(object sender, EventArgs e)//credits
        {
            new CreditsPage().ShowDialog();
        }

        private void HotKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsClicking)
            {
                StartClicking();
            }
            else
            {
                StopClicking();
            }
        }
    }
}
