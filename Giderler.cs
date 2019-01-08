using FlatAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatAutomation
{
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();
        private void button1_Click(object sender, EventArgs e)
        {
            string works = "";
            foreach (Control item in this.groupBox1.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox chk = item as CheckBox;

                    if (chk.Checked==true)
                    {
                        works += item.Text.ToString()+",";


                    }
                }                   

            }
            Gider gd = new Gider();
            gd.DateTimes = dateTimePicker1.Value;
            gd.Giders = works.ToString();
            gd.Total = Convert.ToDecimal(textBox1.Text);
            _uw.giderlerRepo.InsertGiderler(gd);
            MessageBox.Show("Veri başarıyla eklendi ...");
            
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            List<Gider> lstgdr = _uw.giderlerRepo.FillList();
            foreach (Gider item in lstgdr)
            {
                lstGiderler.Items.Add(item.Giders);
                lstTutar.Items.Add(item.Total.ToString("C"));
                lstDate.Items.Add(item.DateTimes.ToShortDateString());


            }
        }
    }
}
