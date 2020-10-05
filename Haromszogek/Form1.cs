using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haromszogek
{
    public partial class frm_fo : Form
    {
        private int a_oldal;
        private int b_oldal;
        private int c_oldal;



        public frm_fo()
        {
            a_oldal = 0;
            b_oldal = 0;
            c_oldal = 0;
            InitializeComponent();
            tb_a_oldal.Text = a_oldal.ToString();
            tb_b_oldal.Text = b_oldal.ToString();
            tb_c_oldal.Text = c_oldal.ToString();
            lb_haromszoglista.Items.Clear();
        }

        private void btn_kilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_szamol_Click(object sender, EventArgs e)
        {
            a_oldal = int.Parse(tb_a_oldal.Text);
            b_oldal = int.Parse(tb_b_oldal.Text);
            c_oldal = int.Parse(tb_c_oldal.Text);

            if (a_oldal == 0 || b_oldal == 0 || c_oldal == 0)
            {
                MessageBox.Show("Valamelyik szám 0, kérem adjon meg egy másik számot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var h = new Haromszog(a_oldal, b_oldal, c_oldal);
                
                List<string> adatok = h.AdatokSzoveg();

                foreach (var i in adatok)
                {
                    lb_haromszoglista.Items.Add(i);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_torol_Click(object sender, EventArgs e)
        {
            if (lb_haromszoglista.Items.Count > 0)
            {
                lb_haromszoglista.Items.Clear();
            }
            else
            {
                MessageBox.Show("Nincs adat", "Hiba", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
