using GestionBibl.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibl
{
    public partial class PageHome : Form
    {
        public PageHome()
        {
            InitializeComponent();
            GEmpunts gEmprint = new GEmpunts();
            addUserConrol(gEmprint);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GClient gClient = new GClient();
            addUserConrol(gClient);

        }

        private void addUserConrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e) 
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            GOuvrages gOuvrages = new GOuvrages();
            addUserConrol(gOuvrages);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            GEmpunts gEmpunts = new GEmpunts();
            addUserConrol(gEmpunts);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
