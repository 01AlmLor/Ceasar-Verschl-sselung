using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1Verschlüsseln_Click(object sender, EventArgs e)
        {
            char[] eingabe = txtEinagbe.Text.ToCharArray();
            int asciicode = 0;
            int schluessel = Convert.ToInt16(txtCode.Text);
            string halter = "";
            
            string ausgabe = "";

            for (int i = 0; i < eingabe.Length; i++)
            {
                asciicode = Convert.ToInt32(eingabe[i]);
                asciicode = asciicode + schluessel;
                eingabe[i] = Convert.ToChar(asciicode);
                halter = Convert.ToString(eingabe[i]);
                ausgabe = ausgabe + halter;

            }
            txtAusgabe.Text = ausgabe;
        }

        private void txtEinagbe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAusgabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntschluesseln_Click(object sender, EventArgs e)
        {
            char[] eingabe = txtAusgabe.Text.ToCharArray();
            int asciicode = 0;
            int schluessel = Convert.ToInt16(txtCode.Text);
            string halter = "";

            string ausgabe = "";

            for (int i = 0; i < eingabe.Length; i++)
            {
                asciicode = Convert.ToInt32(eingabe[i]);
                asciicode = asciicode - schluessel;
                eingabe[i] = Convert.ToChar(asciicode);
                halter = Convert.ToString(eingabe[i]);
                ausgabe = ausgabe + halter;

            }
            txtAusgabeEntschluesselt.Text = ausgabe;
        }

        private void txtAusgabeEntschluesselt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
