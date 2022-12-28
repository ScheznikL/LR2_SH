using System;
using System.Windows.Forms;

namespace LR2_SH
{

    public class University
    {
        static UniversityEqualityComparer UnEqC = new UniversityEqualityComparer(); 
        private string _name;
        protected int _faculty;
        private int _lab = 0;
        private int _lec = 0;
        private int _teachers = 0;
        protected int _engineer = 0;
        protected int _students = 0;

        public University() { }

        public University(string name, int faculty, int lab, int lec, int teachers, int engineer, int students)
        {
            _name = name;
            _faculty = faculty;
            _lab = lab;
            _lec = lec;
            _teachers = teachers;
            _engineer = engineer;
            _students = students;
        }

        public University(University AnotherUn)
        {
            _name = AnotherUn.Name;
            _faculty = AnotherUn.Faculty; 
            _lab = AnotherUn.Lab;
            _lec = AnotherUn.Lec;
            _teachers = AnotherUn.Teachers;
            _engineer = AnotherUn.Engineer;
            _students = AnotherUn.Students;
        }

        public string Name
        {
            get => _name;
            set
            {
                int num;
                if (!string.IsNullOrWhiteSpace(value) && !(int.TryParse(value, out num)))
                    _name = value;
                else
                {
                    MessageBox.Show("Value is incorrect!");
                }
            }
        }

        public int Lab { get => _lab; set => _lab = value; }
        public int Lec { get => _lec; set => _lec = value; }
        public int Teachers { get => _teachers;
            set
            {
                if(value != 0)
                _teachers = value;
                else
                {
                    MessageBox.Show("Amount is too low!");
                }
            }
        }
        public int Engineer
        {
            get => _engineer;
            set
            {
                try
                {
                    if (_engineer < (_lab + _lec) * 2)
                    { _engineer = value; }
                    else if (value < 0)
                    {
                        MessageBox.Show("Incorrect input!");
                    }
                    else
                    {
                        MessageBox.Show("The Laboratories is full.");
                    }
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
            }
        }
        public int Staff => _teachers + _engineer;
        public int Students { get => _students;
            set
            { if(_students < _teachers * 10)
                _students = value;
                else
                {
                    if(!string.IsNullOrWhiteSpace(_name) )
                    MessageBox.Show($"{_name} is full!");
                    else
                    MessageBox.Show($"The University is full!");
                }
            }
        }
        public int Faculty { get => _faculty; set => _faculty = value; }

        public void Addmission(int newStud)
        {
            if (_students < _teachers * 10 || _students==0)
            { _students += newStud; }
            else
            {
                MessageBox.Show("The University is full.");
            }
        }
        public void Expulsion(int newStud)
        {
            if (_students != 0)
            {
                _students -= newStud;
            }
            else
            {
                MessageBox.Show("There is no students left.");
            }
        }
        public void AddLab(int newLab)
        {
            _lab += newLab;
        }
        public void AddLec(int newLec)
        {
            _lec += newLec;
        }
        public void HireEn(int newEn)
        {
            if (_engineer < _lab * 2 || _engineer < _lec * 2)
            { _engineer += newEn; }
            else if (newEn < 0)
            {
                MessageBox.Show("Incorrect input!");
            }
            else
            {
                MessageBox.Show("The Laboratories is full.");
            }
        }
        public void HireTeach(int newTeach)
        {
            _teachers += newTeach;
        }
        public void FireTeach(int num)
        {
            _teachers -= num;
        }
        public void FireEn(int num)
        {
            _engineer -= num;
        }

        public static University operator +(University a, University b)
       => new University(a.Name + "-" + b.Name, a.Faculty + b.Faculty, a.Lab + b.Lab, a.Lec + b.Lec, a.Teachers + b.Teachers, a.Engineer + b.Engineer,
           a.Students + b.Students);

        public int this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return Lec;
                }
                else
                {
                    return Lab;
                }
            }
            set
            {
                if (index == 0)
                {
                    Lec = value;
                }
                else
                {
                    Lab = value;
                }
            }
        }

    }
}

