<<<<<<< HEAD
﻿using DiscordRPC.Logging;
using DiscordRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class Form1 : Form
    {
        bool isMouseDown;
        public Form1()
        {
            InitializeComponent();
        }

        private void AppExitAction(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AppMinimizeAction(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // The following code checks if the primary mouse button is down.
        private void topbar_MouseDown(object sender, MouseEventArgs e) {isMouseDown = true;}
        private void topbar_MouseUp(object sender, MouseEventArgs e) {isMouseDown = false;} 

        private void Topbar_MouseMove(object sender, MouseEventArgs e)
        {
            // If the primary mouse is down on the window bar, the window will be moved.
            if (isMouseDown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }


        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { _ = System.Diagnostics.Process.Start("http://github.com/mariangXzyy/CR6SHERR"); } // Opens the browser on the github repository.

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class cr6sherrgui : Form
    {
        bool isMouseDown;
        public cr6sherrgui()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void topbar_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/mariangXzyy/CR6SHERR");
        }
    }
}
>>>>>>> 1f1131a5cdf9904f085678a435819cf58688151a
