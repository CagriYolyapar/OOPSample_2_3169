using OOPSample_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSample_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLabEkle_Click(object sender, EventArgs e)
        {
            Lab l = new Lab(txtLabNo.Text);
            lstLablar.Items.Add(l);
        }

        private void lstLablar_Click(object sender, EventArgs e)
        {
            if (lstLablar.SelectedIndex>-1)
            {
                lblLab.Text = (lstLablar.SelectedItem as Lab).LabNo;
            }
        }

        private void btnFormGec_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(lstLablar.Items);
            f2.ShowDialog();
        }
    }
}
