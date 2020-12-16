using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace DiscordTyper
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        internal static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        //List<Timer> timers = new List<Timer>();
        Dictionary<Button, Command> commands = new Dictionary<Button, Command>();

        public Form1()
        {
            InitializeComponent();
        }

        public class Command {
            string command;
            int interval;
            int counter; 
            Timer timer;
            Timer labelTimer; 
            IntPtr discordPtr;
            public bool min = true;
            Label timeLabel;

            public Command(Label time)
            {
                this.timeLabel = time; 
            }

            //TODO ADD TIMER FOR COUNTDOWN 


            public void Start(string command, int interval)
            {
                this.command = command;
                this.interval = interval;

                counter = interval; 
                timeLabel.Text = interval.ToString();
                labelTimer = new Timer(); 
                labelTimer.Interval = 1000;
                labelTimer.Tick += new EventHandler(tick);
                labelTimer.Start(); 
                
                discordPtr = findDiscord();

                try { timer.Stop(); }  catch { }
                timer = new Timer();
                timer.Tick += (sender2, e2) => f(sender2, e2, command);
                timer.Interval = 1000 * interval;
                timer.Start();
            }

            public void Stop()
            {
                try { timer.Stop(); labelTimer.Stop(); timeLabel.Text = "0"; } catch { }
            }

            private void tick(object e, EventArgs a)
            {
                counter--; 
                timeLabel.Text = counter.ToString(); 
            }

            void f(object s, EventArgs ea, string c)
            {
                counter = interval; 
                IntPtr current = GetForegroundWindow();
                ShowWindow(discordPtr, 9);
                SetForegroundWindow(discordPtr);
                SendKeys.SendWait(c + "{ENTER}");
                //SendKeys.Send(c + "{ENTER}");
                //Thread.Sleep(100);
                if (min)
                    ShowWindow(discordPtr, 6);
                ShowWindow(current, 5);
                SetForegroundWindow(current);
            }

            public IntPtr findDiscord()
            {
                Process[] processRunning = Process.GetProcesses();
                foreach (Process pr in processRunning)
                {
                    //MessageBox.Show(pr.ProcessName);
                    if (pr.ProcessName == "Discord" && pr.MainWindowHandle != IntPtr.Zero)
                    {
                        IntPtr discordPtr = pr.MainWindowHandle;
                        return discordPtr;
                    }
                }
                return IntPtr.Zero;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            foreach (Command c in commands.Values) { c.Stop(); }

            string c1 = "", c2 = "", c3 = "";
            int i1 = 0, i2 = 0, i3 = 0; 
            try
            {
                c1 = command1.Text;
                c2 = command2.Text;
                c3 = command3.Text;

                if (!String.IsNullOrEmpty(interval1.Text)) { i1 = Int32.Parse(interval1.Text); }
                if (!String.IsNullOrEmpty(interval2.Text)) { i2 = Int32.Parse(interval2.Text); }
                if (!String.IsNullOrEmpty(interval3.Text)) { i3 = Int32.Parse(interval3.Text); }
            }
            catch
            {
                MessageBox.Show("Please enter a whole number."); 
            }

            commands.Clear(); 
            if (c1 != "" && i1 != 0) { commands.Add(start1, new Command(time1)); commands[start1].Start(c1, i1); }
            if (c2 != "" && i2 != 0) { commands.Add(start2, new Command(time2)); commands[start2].Start(c2, i2); }
            if (c3 != "" && i3 != 0) { commands.Add(start3, new Command(time3)); commands[start3].Start(c3, i3); }

           
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach(Command c in commands.Values) { c.Stop();  }
        }


        private void minimised_CheckedChanged(object sender, EventArgs e)
        {
            foreach(Command c in commands.Values) { c.min = minimised.Checked;  }
        }

        private void start1_Click(object sender, EventArgs e)
        {
            string c = "";
            int i = 0;  
            try
            {
                c = command1.Text;
                if (!String.IsNullOrEmpty(interval1.Text)) { i = Int32.Parse(interval1.Text); }
            }
            catch
            {
                MessageBox.Show("Please enter a whole number.");
            }
            if(c != "" && i != 0)
            {
                if (commands.Keys.Contains(start1)) { commands[start1].Stop();  commands[start1].Start(c, i); }
                else
                {
                    commands.Add(start1, new Command(time1));
                    commands[start1].Start(c, i); 
                }
            }
            
        }

        private void start2_Click(object sender, EventArgs e)
        {
            string c = "";
            int i = 0;
            try
            {
                c = command2.Text;
                if (!String.IsNullOrEmpty(interval2.Text)) { i = Int32.Parse(interval2.Text); }
            }
            catch
            {
                MessageBox.Show("Please enter a whole number.");
            }
            if (c != "" && i != 0)
            {
                if (commands.Keys.Contains(start2)) { commands[start2].Stop(); commands[start2].Start(c, i); }
                else
                {
                    commands.Add(start2, new Command(time2));
                    commands[start2].Start(c, i);
                }
            }
        }

        private void start3_Click(object sender, EventArgs e)
        {
            string c = "";
            int i = 0;
            try
            {
                c = command3.Text;
                if (!String.IsNullOrEmpty(interval3.Text)) { i = Int32.Parse(interval3.Text); }
            }
            catch
            {
                MessageBox.Show("Please enter a whole number.");
            }
            if (c != "" && i != 0)
            {
                if (commands.Keys.Contains(start3)) { commands[start3].Stop(); commands[start3].Start(c, i); }
                else
                {
                    commands.Add(start3, new Command(time3));
                    commands[start3].Start(c, i);
                }
            }
        }

        private void stop1_Click(object sender, EventArgs e)
        {
            if(commands.Keys.Contains(start1)) { commands[start1].Stop();  }
        }

        private void stop2_Click(object sender, EventArgs e)
        {
            if (commands.Keys.Contains(start2)) { commands[start2].Stop(); }
        }

        private void stop3_Click(object sender, EventArgs e)
        {
            if (commands.Keys.Contains(start3)) { commands[start3].Stop(); }
        }
    }
}
