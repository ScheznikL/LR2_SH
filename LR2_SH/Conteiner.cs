using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.CompilerServices;


namespace LR2_SH
{
    class Conteiner /*: IRaiseItemChangedEvents*/ /*: INotifyPropertyChanged*/
    {
        // event ListChangedEventHandler ListChanged;
        //public event PropertyChangedEventHandler PropertyChanged;
        public static University Univer = new University();
        public static UniversityEqualityComparer boxEqC = new UniversityEqualityComparer();
        public static Dictionary<University, string> UnDict = new Dictionary<University, string>(boxEqC)
        {
            { new University("NURE",23,100,200,300,600,2000),"NURE"},
            { new University("Karazina",50,150,100,100,300,1500),"Karazina"},
            { new University("HPI",100,130,1550,130,390,2500), "HPI"}
        };
        public static BindingList<University> ForDisplay = new BindingList<University>()
            {
             new University("NURE",23,100,200,300,600,2000),//
             new University("Karazina",50,150,100,100,300,1500),
             new University("HPI",100,130,1550,130,390,2500)
            };

        //public bool RaisesItemChangedEvents => ((IRaiseItemChangedEvents)ForDisplay).RaisesItemChangedEvents;

        public static void addNewUniversuty()
        {

            if (!UnDict.ContainsKey(Univer))
            {
                UnDict.Add(Univer, Univer.Name);
                ForDisplay.Add(Univer);
            }
            else
            {
                Console.WriteLine("Such University alredy exist.");
            }
            Univer = new University();
        }
        //private void NotifyPropertyChanged(String propertyName = "Lab")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        //     protected void OnPropertyChanged(string propertyName)
        //=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        //     protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        //     {
        //         if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        //         field = value;
        //         OnPropertyChanged(propertyName);
        //         return true;
        //     }

        public static void Unite(University A, University B)
        {
            if (UnDict.ContainsKey(A) && UnDict.ContainsKey(B))
            {
                University United = A + B;
                UnDict.Remove(A);
                UnDict.Remove(B);
                UnDict.Add(United, United.Name);
                ForDisplay.AllowRemove = true;
                ForDisplay.Remove(A);
                ForDisplay.Remove(B);
                ForDisplay.Add(United);
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
