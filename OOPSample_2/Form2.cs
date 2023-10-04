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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(ListBox.ObjectCollection lablar)
        {
            InitializeComponent();
            foreach (Lab item in lablar)
            {
                cmbLablar.Items.Add(item);
            }

        }

        private void cmbLablar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLablar.SelectedIndex>-1)
            {
                lblLab.Text = (cmbLablar.SelectedItem as Lab).LabNo;
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (cmbLablar.SelectedIndex>-1)
            {
                Ogrenci o = new Ogrenci(txtIsim.Text,txtSoyisim.Text,cmbLablar.SelectedItem as Lab);
                (cmbLablar.SelectedItem as Lab).Ogrenciler.Add(o);
                lstOgrenciler.Items.Add(o); 

            }
        }

        private void lstOgrenciler_Click(object sender, EventArgs e)
        {
            if (lstOgrenciler.SelectedIndex>-1)
            {
                lblOgrenci.Text = (lstOgrenciler.SelectedItem as Ogrenci).OgrenciBilgi();
            }
        }
    }
}
