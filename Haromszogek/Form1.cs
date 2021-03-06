﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Haromszogek
{
    public partial class frm_fo : Form
    {
        private double a_oldal;
        private double b_oldal;
        private double c_oldal;



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
            try
            {
                a_oldal = double.Parse(tb_a_oldal.Text);
                b_oldal = double.Parse(tb_b_oldal.Text);
                c_oldal = double.Parse(tb_c_oldal.Text);

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
            catch (Exception ex)
            {

                MessageBox.Show("Számot adj meg more!","Hiba!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_a_oldal.Focus();
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

        private void btn_fajlbol_Click(object sender, EventArgs e)
        {
            lb_haromszoglista.Items.Clear();
            ofd_megnyitas.ShowDialog();
            string winDir = Environment.GetEnvironmentVariable("windir");
            StreamReader olvas = new StreamReader("adatok.txt");
            while (!olvas.EndOfStream)
            {

                string[] sor = olvas.ReadLine().Split(';');
                
                List<Haromszog> adatok = new List<Haromszog>();
                adatok = lb_haromszoglista.Items.Add(new Haromszog(a_oldal = double.Parse(sor[0]), b_oldal = double.Parse(sor[1]), c_oldal = double.Parse(sor[2])));
                foreach (var f in adatok)
                {
                    lb_haromszoglista.Items.Add(f);
                }

            }
            olvas.Close();
        }

        private void tb_a_oldal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
