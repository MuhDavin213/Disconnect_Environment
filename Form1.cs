﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnect_Environment
{
    public partial class FormHalamanUtama : Form
    {
        public FormHalamanUtama()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataProdi fm = new FormDataProdi();
            fm.Show();
            this.Hide();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataMahasiswa fm = new FormDataMahasiswa();
            fm.Show();
            this.Hide();
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatusMahasiswa fm = new FormStatusMahasiswa();
            fm.Show();
            this.Hide();
        }
    }
}
