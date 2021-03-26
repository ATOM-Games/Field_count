using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POLE
{
    public partial class MAINform : Form
    {
        public int XX = 0, YY = 0, XXXX = 0, YYYY = 0;
        public int[,] Lista;
        public MAINform(){InitializeComponent();}
        private void Exit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void NewPole_Click(object sender, EventArgs e) {
            NewPole NPOL = new NewPole();
            NPOL.manform = this;
            NPOL.Show();
        }
        public void NaRazm(int XXX, int YYY) {
            XX = XXX; YY = YYY;
            this.Width = 20 * XX + 40;
            this.Height = 20 * YY + 80;
            Lista = new int[YY, XX];
            for (int y = 0; y < YY; y++)
            {
                for (int x = 0; x < XX; x++)
                {
                    Lista[y, x] = 0;
                }
            }

            Pravka.Enabled = true;
            GetVoidButt();
        }
        private void PoleClick(object sender, EventArgs e) {
            int xl = Math.Abs( (((Button)sender).Location.X - 10)  / 20);
            int yl = Math.Abs( (((Button)sender).Location.Y - 30) / 20);
            if (Lista[yl, xl] == 1) {
                BUT[yl, xl].BackColor = Color.White;
                Lista[yl, xl] = 0;
            } else {
                BUT[yl, xl].BackColor = Color.Black;
                Lista[yl, xl] = 1;
            }
        }
        private void Cleane_Click(object sender, EventArgs e) {
            for (int y = 0; y < YY; y++) {
                for (int x = 0; x < XX; x++) {
                    Lista[y, x] = 0;
                    BUT[y, x].BackColor = Color.White;
                }
            }
        }
        public void ClearButon()
        {
            for (int y = 0; y < YY; y++)
            {
                for (int x = 0; x < XX; x++)
                {
                    this.Controls.Remove(BUT[y, x]);
                }
            }
        }
        private void Proverit_Click(object sender, EventArgs e) {
            int ST = 0;
            bool Flag = false;
            string K = "";
            do{
                Flag = false;
                for (int y = 0; y < YY; y++) {
                    for (int x = 0; x < XX; x++) {
                        if (Lista[y, x] == 0){
                            Flag = true;
                            Zam(x, y);
                            ST++;
                            break;
                        }
                    }
                    if (Flag == true) { break; }
                }
            }while(Flag==true);
            for (int y = 0; y < YY; y++)
            {
                for (int x = 0; x < XX; x++)
                {
                    if (Lista[y, x] == 2)
                    {
                        Lista[y, x] = 0;
                    }
                }
            }
            if (ST % 10 == 1 && ST % 100 != 11)
            {
                K = " поле";
            }
            else
            {
                if ((ST % 10 > 1 && ST % 10 < 5) && ST % 100 != 12 && ST % 100 != 13 && ST % 100 != 14)
                {
                    K = " поля";
                }
                else 
                {
                    K = " полей";
                }
            }

            MessageBox.Show("У Вас "+ST+K, "Готово!");
        }

        private void Zam(int x, int y) {
            Lista[y,x]=2;
            if (y > 0 && Lista[y - 1, x] == 0) { Zam(x, y - 1); }
            if (y < YY-1 && Lista[y + 1, x] == 0) { Zam(x, y + 1); }
            if (x > 0 && Lista[y, x - 1] == 0) { Zam(x - 1, y); }
            if (x < XX-1 && Lista[y, x + 1] == 0) { Zam(x + 1, y); }
        }
    }
}
