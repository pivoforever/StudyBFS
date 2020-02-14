using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_кадровDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.учет_кадровDataSet.Пользователи);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int index1=bindingSource1.Find("Логин",textBox1.Text);
            int index2 = bindingSource1.Find("Пароль", textBox2.Text);
            if ((index1 > -1) && (index2 > -1) && (index1 == index2))
            {
                Form2 mainm = new Form2();
                mainm.Show();
                this.Hide();
            }
            else MessageBox.Show("Доступ запрещен");
        }
    }
}
