﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthWorksApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            ViewDoctors vDoctors = new ViewDoctors();
            vDoctors.ShowDialog();
        }
    }
}