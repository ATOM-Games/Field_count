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
    public partial class NewPole : Form
    {
        public MAINform mainform;
        public NewPole()
        {
            InitializeComponent();
        }
        private void CreatePole_Click(object sender, EventArgs e)
        {
            if (XXX.Value <= 1 || YYY.Value <= 1)
            {
                MessageBox.Show("Слишком маленькие размеры поля", "Ошибка!");
            }
            else
            {
                if (mainform.XX > 0 && mainform.YY > 0)
                {
                    mainform.ClearButon();
                }
                mainform.NaRazm(Convert.ToInt32(XXX.Value), Convert.ToInt32(YYY.Value));
                this.Close();
            }
        }

        private void Otmena_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
