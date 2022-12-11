using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum7_Task2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetRes_Click(object sender, EventArgs e)
        {
            string str = "", chr = "";

            try
            {
                str = textBoxString.Text;
                chr = textBoxChar.Text;
                if (str.Length == 0 || chr.Length == 0) throw new Exception("Строка не должна быть пустой!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            List<string> list = new List<string>(str.Split('\u002C', ' '));
            m1:
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].EndsWith(chr))
                {
                    list.RemoveAt(i);
                    goto m1;
                }
            }
            textBoxResArea.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                textBoxResArea.Text +=(list[i] + " ");
            }

        }
    }
}
