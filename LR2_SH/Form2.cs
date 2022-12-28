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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (WhoorWhat.Text == "Enter a number of engineer to hire.")
            {
                button1.Text = "Hire";
                num = CheckTheNum(num);
                if (num != 0)
                {
                    Conteiner.UnDict.Remove(Conteiner.Univer);
                    Conteiner.Univer.HireEn(num);
                    Conteiner.UnDict.Add(Conteiner.Univer, Conteiner.Univer.Name);
                    Conteiner.ForDisplay[Conteiner.ForDisplay.IndexOf(Conteiner.Univer)].Engineer = Conteiner.Univer.Engineer;
                }
            }
            else if (WhoorWhat.Text == "Enter a number of teachers to hire.")
            {
                button1.Text = "Hire";
                num = CheckTheNum(num);
                if (num != 0)
                {
                    Conteiner.UnDict.Remove(Conteiner.Univer);
                    Conteiner.Univer.HireTeach(num);
                    Conteiner.UnDict.Add(Conteiner.Univer, Conteiner.Univer.Name);
                    Conteiner.ForDisplay[Conteiner.ForDisplay.IndexOf(Conteiner.Univer)].Teachers = Conteiner.Univer.Teachers;
                }
            }
            else if (WhoorWhat.Text == "Enter a number of engineer to fire.")
            {
                button1.Text = "Fire";
                num = CheckTheNum(num);
                if (num != 0)
                {
                    Conteiner.UnDict.Remove(Conteiner.Univer);
                    Conteiner.Univer.FireEn(num);
                    Conteiner.UnDict.Add(Conteiner.Univer, Conteiner.Univer.Name);
                    Conteiner.ForDisplay[Conteiner.ForDisplay.IndexOf(Conteiner.Univer)].Engineer = Conteiner.Univer.Engineer;
                }
            }
            else if (WhoorWhat.Text == "Enter a number of teachers to fire.")
            {
                button1.Text = "Fire";
                num = CheckTheNum(num);
                if (num != 0)
                {
                    Conteiner.UnDict.Remove(Conteiner.Univer);
                    Conteiner.Univer.FireTeach(num);
                    Conteiner.UnDict.Add(Conteiner.Univer, Conteiner.Univer.Name);
                    Conteiner.ForDisplay[Conteiner.ForDisplay.IndexOf(Conteiner.Univer)].Teachers = Conteiner.Univer.Teachers;
                }
            }
            else if (WhoorWhat.Text == "Enter a number of lectoriums to build.")
            {
                button1.Text = "Build";
                num = CheckTheNum(num);
                if (num != 0)
                {
                    Conteiner.UnDict.Remove(Conteiner.Univer);
                    Conteiner.Univer.AddLec(num);
                    Conteiner.UnDict.Add(Conteiner.Univer, Conteiner.Univer.Name);
                    Conteiner.ForDisplay[Conteiner.ForDisplay.IndexOf(Conteiner.Univer)].Lec = Conteiner.Univer.Lec;
                }
                
            }
            else if (WhoorWhat.Text == "Enter a number of laboratories to build.")
            {
                button1.Text = "Build";
                num = CheckTheNum(num);
                if (num != 0)
                {
                    Conteiner.UnDict.Remove(Conteiner.Univer);
                    Conteiner.Univer.AddLab(num);
                    Conteiner.UnDict.Add(Conteiner.Univer, Conteiner.Univer.Name);
                    Conteiner.ForDisplay[Conteiner.ForDisplay.IndexOf(Conteiner.Univer)].Lab = Conteiner.Univer.Lab;
                }
            }
            else if (WhoorWhat.Text == "Enter a number of students for exclusion.")
            {
                button1.Text = "Exclusion";
                num = CheckTheNum(num);
                if (num != 0)
                {
                    Conteiner.UnDict.Remove(Conteiner.Univer);
                    Conteiner.Univer.Expulsion(num);
                    Conteiner.UnDict.Add(Conteiner.Univer, Conteiner.Univer.Name);
                    Conteiner.ForDisplay[Conteiner.ForDisplay.IndexOf(Conteiner.Univer)].Students = Conteiner.Univer.Students;
                }
            }
            else //"Enter a number of students for addmition."
            {
                    num = CheckTheNum(num);
                if (num != 0)
                {
                    Conteiner.UnDict.Remove(Conteiner.Univer);
                    Conteiner.Univer.Addmission(num);
                    Conteiner.UnDict.Add(Conteiner.Univer, Conteiner.Univer.Name);
                    Conteiner.ForDisplay[Conteiner.ForDisplay.IndexOf(Conteiner.Univer)].Students = Conteiner.Univer.Students;
                }
            }
            Close();
        }

        private int CheckTheNum(int num)
        {
            try
            {
                num = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception err)
            {
                Form1 form = new Form1();
                if (err is FormatException)
                {
                    MessageBox.Show(form.Owner, $"Incorrect input!");
                }
                else
                {
                    MessageBox.Show(form.Owner, $"Error!");
                }

            }

            return num;
        }
    }
}
