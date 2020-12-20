using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = 'A';
            return (char)(((ch + key - d) % 26) + d);
        }

        public static string encipher(string input, string awal, string akhir)
        {
            int key = (akhir[0] < awal[0]) ? akhir[0] - awal[0] + 26: akhir[0] - awal[0];
            string output = "";
            
            foreach (char ch in input)
            {
                output += cipher(ch, key);
            }
            return output;
        }

        private void buttoncvrt_Click(object sender, EventArgs e)
        {
            labelout.Text = encipher(textBoxnama.Text.ToUpper(), textBoxawal.Text.ToUpper(), textBoxakhir.Text.ToUpper());
        }
    }
}
