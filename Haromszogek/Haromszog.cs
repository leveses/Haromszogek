﻿using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Haromszogek
{
    internal class Haromszog
    {
        private int a_oldal;
        private int b_oldal;
        private int c_oldal;
        public  double Terulet { get; private set; }
        public double Kerulet { get; private set; }
        public bool Szerkesztheto { get; private set; }
        public double s { get; set; }

        private void Szerk()
        {
            if (c_oldal > b_oldal+a_oldal && a_oldal > b_oldal + c_oldal && b_oldal > c_oldal + a_oldal)
            {
                Szerkesztheto = true;
            }
            else
            {
                Szerkesztheto = false;
                Terulet = 0;
                Kerulet = 0;
            }
        }
        
        
        private double TeruletSzammitas(double eredmenyT)
        {
            s = (a_oldal + b_oldal + c_oldal) / 2;
            return eredmenyT = Math.Sqrt(s * (s - a_oldal) * (s - b_oldal) * (s - c_oldal));
        }
        private double KeruletSzammitas(double eredmenyK)
        {
            return eredmenyK;
        }

        public Haromszog(int a_oldal, int b_oldal, int c_oldal)
        {
            this.a_oldal = a_oldal;
            this.b_oldal = b_oldal;
            this.c_oldal = c_oldal;
        }
    }
}