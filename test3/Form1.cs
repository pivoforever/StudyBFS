using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "adventureWorksDataSet.Password". При необходимости она может быть перемещена или удалена.
            this.passwordTableAdapter.Fill(this.adventureWorksDataSet.Password);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "adventureWorksDataSet.Culture". При необходимости она может быть перемещена или удалена.
            this.cultureTableAdapter.Fill(this.adventureWorksDataSet.Culture);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
