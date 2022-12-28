using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2_SH
{
    public partial class Form3 : Form
    {
        private BindingSource _bs;
        public Form3()
        {
            InitializeComponent();
            _bs = new BindingSource();
            _bs.DataSource = Conteiner.Univer;
            dataGridView1.DataSource = _bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conteiner.addNewUniversuty();
            Close();
        }
    }
}
