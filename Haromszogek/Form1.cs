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

            StringBuilder szoveg = new StringBuilder();
            szoveg.Append(" a: ");
            szoveg.Append(a_oldal.ToString());
            szoveg.Append(" b: ");
            szoveg.Append(b_oldal.ToString());
            szoveg.Append(" c: ");
            szoveg.Append(c_oldal.ToString());
            
            if (a_oldal == 0 || b_oldal == 0 || c_oldal == 0)
            {
                MessageBox.Show("Valamelyik szám 0, kérem adjon meg egy másik számot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var h = new Haromszog(a_oldal, b_oldal, c_oldal);
                if (h.Szerkesztheto)
                {
                    MessageBox.Show("Kerület: " + h.Kerulet + " Terület: " + h.Terulet);
                }
                else
                {
                    MessageBox.Show("Nem szerkeszthető belőle háromszög");
                }
                
            }
        }
    }
}
