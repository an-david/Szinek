using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szinek
{
    public partial class Form_Ablak : Form
    {
        public Form_Ablak()
        {
            InitializeComponent();
        }

        /**
         *  Csak Angol betűszíneket fogad el.
         */

        private void button_AblakSzin_Click(object sender, EventArgs e)
        {
            label_Hiba.Text = "";

            try
            {
                Form_Ablak.ActiveForm.BackColor = Color.FromName(textBox_AblakSzin.Text);
            } catch (Exception)
            {
                label_Hiba.Text = "Csak színeket írhat be!";
            }
        }

        private void button_BetuSzin_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Ablak.ActiveForm.ForeColor = Color.FromName(textBox_BetuSzin.Text);
            } catch (Exception)
            {

            }
        }
    }
}
