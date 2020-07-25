using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MetroFramework.Forms;
using MetroFramework;
using System.Windows.Forms;

namespace Screen
{
    public partial class Splashscreen : MetroForm
    {
        int a = 0;
        public Splashscreen()
        {
            InitializeComponent();
        }

        public void CloseSplash()
        {
            Invoke((MethodInvoker)delegate
            {
                this.Close();
            });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
