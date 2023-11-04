using Guna.UI2.WinForms;
using OutlookDemo.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Tab_Start tab = new Tab_Start();
            addUserCOntrol(tab);
        }

        private void addUserCOntrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
        }
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Tab_Bubble tab = new Tab_Bubble();
            addUserCOntrol(tab);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Tab_Shaker tab = new Tab_Shaker();
            addUserCOntrol(tab);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Tab_Bitonic tab = new Tab_Bitonic();
            addUserCOntrol(tab);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Tab_Sort tab = new Tab_Sort();
            addUserCOntrol(tab);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
