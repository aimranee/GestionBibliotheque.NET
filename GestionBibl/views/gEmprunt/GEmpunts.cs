﻿using GestionBibl.Model;
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
    public partial class GEmpunts : UserControl
    {
        public GEmpunts()
        {
            InitializeComponent();
        }

        private void GEmpunts_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NEmprunt form = new NEmprunt();
            form.ShowDialog();
        }
    }
}