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
    public partial class mainM : Form
    {
        public mainM()
        {
            InitializeComponent();
        }

        private void mainM_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_кадровDataSet.персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.учет_кадровDataSet.персонал);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            персоналBindingSource.Filter = comboBox1.Text + " LIKE'%" + textBox1.Text + "%'";
        }
    }
}
