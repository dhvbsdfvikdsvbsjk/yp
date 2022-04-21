using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Data.SqlClient;

namespace _0402
{
    public partial class Form1 : Form
    {
        public static string str = @"Data Source=PK312-120;Initial Catalog=z1;Integrated Security=True";
        private SqlConnection con = new SqlConnection(str);
        public string h = "";
        public Form1()
        {
            InitializeComponent();
            string result = Interaction.InputBox("Введите текст:");
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey helloKey = currentUserKey.OpenSubKey("WFWF");

            string ye;
            ye = helloKey.GetValue("Identifier").ToString();
            if (ye != "001")
            {
                MessageBox.Show("Вы пользуетесь нелицензионной программой");
                this.Close();
            }
            helloKey.Close();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e) // авторизация
        {
            string logi = @"SELECT z1(*) Логин = '"+textBox1.Text+"'";
            if (comboBox1.Text == "Администратор")
            {
                if(textBox1.Text == "aeeae" || textBox1.Text == "123" || textBox1.Text == "qwe" || textBox1.Text == "счми" || textBox1.Text == "321" || textBox1.Text == "001")
                {
                    Form4 f = new Form4();
                    f.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("неочень");
                }
               
            }
            else if(comboBox1.Text == "Сотрудник")
            {
                if (textBox1.Text == "aeeae" || textBox1.Text == "123" || textBox1.Text == "qwe" || textBox1.Text == "счми" || textBox1.Text == "321" || textBox1.Text == "001")
                {
                    Form3 f = new Form3();
                    f.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("неочень");
                }
            }
            else
            {
                MessageBox.Show("0-0");
            }
            
        }
        private void button2_Click(object sender, EventArgs e) // регистрация
        {
            A.a1 = textBox1.Text;
            A.lo = comboBox1.Text;
            if (comboBox1.Text == "Администратор")
            {
                foreach (char t in textBox2.Text)
                {
                    h += Convert.ToString(Convert.ToInt32(t) + 7) + "#";
                }
                A.a2 = h;
                Form2 f = new Form2();
                f.Show();
                Hide();
            }
            else if (comboBox1.Text == "Сотрудник")
            {
                foreach (char t in textBox2.Text)
                {
                    h += Convert.ToString(Convert.ToInt32(t) + 7) + "#";
                }
                A.a2 = h;
                Form2 f = new Form2();
                f.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("0-0");
            }
        }
    }
}
