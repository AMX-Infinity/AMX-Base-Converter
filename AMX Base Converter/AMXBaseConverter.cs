/*
 * AMX Base Converter
 * Convert numbers between bases.
 * 
 * Author: Afaan Bilal (https://afaan.ml)
 * Copyright Afaan Bilal, AMX Infinity (https://www.amxinfinity.ml)
 *  
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMX_Base_Converter
{
    public partial class AMXBaseConverter : Form
    {
        public AMXBaseConverter()
        {
            InitializeComponent();
        }

        private void AMXBaseConverter_Load(object sender, EventArgs e)
        {
            for (int i = 2; i < 10; i++)
            {
                cbFromBase.Items.Add(i);
                cbToBase.Items.Add(i);
            }
        }

        private string base_convert(string number, int fromBase, int toBase)
        {
            StringBuilder res = new StringBuilder();
            long n = Int32.Parse(number);
            if (fromBase > toBase)
            {
                while (n > 0)
                {
                    res.Append((char)(n % toBase + '0'));
                    n /= toBase;
                }
                string r = res.ToString();
                char[] cr = r.ToCharArray();
                Array.Reverse(cr);
                StringBuilder rcb = new StringBuilder();
                foreach (char c in cr)
                    rcb.Append(c);
                return rcb.ToString();
            }
            else
            {
                long ret = 0;
                for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
                    ret += (int)(number[i] - '0') * (int)Math.Pow((double)fromBase, (double)j);
                res.Append(ret);
            }
            return res.ToString();
        }
        
        private long base_convert(long number, short fromBase, short toBase)
        {
            string toTen = base_convert(number.ToString(), fromBase, 10);
            return long.Parse(base_convert(toTen, 10, toBase));
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            long number = 0;
            if (tbNumIn.Text.Trim() == string.Empty || !long.TryParse(tbNumIn.Text.Trim(), out number))
            {
                MessageBox.Show("Please enter a valid number.", "AMX Base Converter");
                return;
            }

            short fb, tb;
            if (cbFromBase.SelectedItem == null || cbToBase.SelectedItem == null ||
                !short.TryParse(cbFromBase.SelectedItem.ToString(), out fb) ||
                !short.TryParse(cbToBase.SelectedItem.ToString(), out tb) ||
                fb < 2 || fb > 10 ||
                tb < 2 || tb > 10)
            {
                MessageBox.Show("Please select a proper base from the list.", "AMX Base Converter");
                return;
            }

            tbNumOut.Text = base_convert(number, fb, tb).ToString();
        }
        
        private void linkCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amxinfinity.ml");
            System.Diagnostics.Process.Start("https://afaan.ml");
        }

    }
}
