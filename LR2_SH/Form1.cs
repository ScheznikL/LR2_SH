using System;
using System.Windows.Forms;

namespace LR2_SH
{
    public partial class Form1 : Form
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        private BindingSource _bs;

        public Form1()
        {
            InitializeComponent();

            _bs = new BindingSource();
            _bs.DataSource = Conteiner.ForDisplay; 
            dataGridView1.DataSource = _bs;
            Conteiner.ForDisplay.AllowNew = true;
            Conteiner.ForDisplay.AllowRemove = false;

            // Raise ListChanged events when new parts are added.
            Conteiner.ForDisplay.RaiseListChangedEvents = true;
            TbUnName.DataBindings.Add("Text", _bs, "Name");
            tbFaculty.DataBindings.Add("Text", _bs, "Faculty");
        }

        private void BtDone_OnClick(object sender, EventArgs e)
        {
            Close();
        }

    public static University addNewUniversuty(string name, int faculty, int lab, int lec, int teachers, int engineer, int students)
        {
            University newUn;
            return newUn = new University(name, faculty, lab, lec, teachers, engineer, students);
        }

        private void BtAddmition_Click(object sender, EventArgs e)
        {
            FormIntrraction("Enter a number of students for addmition.", "Addmition");
        }

        private void BtExpulsion_Click(object sender, EventArgs e)
        {
            FormIntrraction("Enter a number of students for exclusion.", "Expulsion");
        }

        private void BtAddLaboratory_Click(object sender, EventArgs e)
        {
            FormIntrraction("Enter a number of laboratories to build.", "Build");
        }

        private void BtAddLectorium_Click(object sender, EventArgs e)
        {
            FormIntrraction("Enter a number of lectoriums to build.", "Build");
        }

        private void BtHireEngineer_Click(object sender, EventArgs e)
        {
            FormIntrraction("Enter a number of engineer to hire.", "Hire");

        }

        private void BtHireTeacher_Click(object sender, EventArgs e)
        {
            FormIntrraction("Enter a number of teachers to hire.", "Hire");
        }

        private void BtFireEngineer_Click(object sender, EventArgs e)
        {
            FormIntrraction("Enter a number of engineer to fire.", "Fire");
        }

        private void BtFireTeacher_Click(object sender, EventArgs e)
        {
            FormIntrraction("Enter a number of teachers to fire.", "Fire");
        }

        public void FormIntrraction(string TobeDisplayed, string ToButton)
        {

            int i=-1;
            Int32 selectedRowCount =
      dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Conteiner.Univer = row.DataBoundItem as University;
                    i = row.Index;
                }
            }
            else
            {
                MessageBox.Show("You can modify only one element at a time.");
            }
            Form2 form = new Form2();
            form.Show();
            form.WhoorWhat.Text = TobeDisplayed;
            form.button1.Text = ToButton;
            _bs.DataSource = Conteiner.ForDisplay;
            _bs.ResetBindings(false);
            //dataGridView1.DataSource = _bs;
            //dataGridView1.Update();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conteiner.Univer = new University();
            Form3 form = new Form3();
            form.Show();
        }

        private void BtUniteUn_Click(object sender, EventArgs e)
        {
            int i = 0;
            University[] ToBeUnited = new University[2];
            Int32 selectedRowCount =
       dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount <= 2)
            {
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    University un = row.DataBoundItem as University;
                    if (un != null)
                    {
                        ToBeUnited[i] = un;
                        i++;
                    }
                }
            }
            Conteiner.Unite(ToBeUnited[0], ToBeUnited[1]);
            _bs.ResetBindings(false);
        }



    }
}
