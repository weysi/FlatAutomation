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
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();
        
        private void button1_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBox1.Text)))
            {

                Gelir gd = new Gelir();
                gd.DateTimes = dateTimePicker1.Value.Date;
                gd.DaireNo = "Daire" + numericUpDown1.Value.ToString();
                gd.Total = Convert.ToDecimal(textBox1.Text);

                _uw.gelirlerRepo.InsertGelirler(gd);
                MessageBox.Show("Veriler Başarıyla Eklendi...");
            

            }
            
        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            List<Gelir> gelirs = _uw.gelirlerRepo.FillList();
            foreach (Gelir item in gelirs)
            {
                lstDaire.Items.Add(item.DaireNo.ToString());
                lstDate.Items.Add(item.DateTimes.ToShortDateString());
                lstTutar.Items.Add(item.Total.ToString("C"));

            }
        }
    }
}
