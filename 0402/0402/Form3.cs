using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0402
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "z1DataSet.tab". При необходимости она может быть перемещена или удалена.
            this.tabTableAdapter.Fill(this.z1DataSet.tab);
            textBox1.Text = A.f;
            textBox2.Text = A.n;
            textBox3.Text = A.md;
            textBox4.Text = A.date;
            textBox5.Text = A.pas;
            textBox6.Text = A.pod;
            textBox7.Text = A.dol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
