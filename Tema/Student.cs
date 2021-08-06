using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Tema
{
    public class Student
    {
        int Id;
        string Name;
        int Age, Class;
        int[] note = new int[5];
        double medie;
        public Student(string n = "", int v = 17, int a = 1, int[] not = null)
        {
            this.Name = n;
            this.Age = v;
            this.Class = a;
            int k = -1;
            if(not != null)
                foreach (var i in not)
                {
                    note[++k] = i;
                }
           
            
        }
        public double Mediat()
        {
            double s = 0;
            foreach (var i in this.note)
            {
                s += i;
            }
            this.medie = Math.Round(s/5,2);
            return Math.Round(s / 5, 2);
        }
       
        public string AfisareStudent()
        {
            return $"{this.Name}, {this.Age} ani, anul {this.Class}, media {this.Medie}";
        }
        public string Nume
        {
            get { return this.Name; }
        }

        public int Varsta
        {
            get { return this.Age; }
        }

        public int An
        {
            get { return this.Class; }
        }

        public double Medie
        {
            set { this.medie = value; }
            get { return Math.Round(this.medie , 2); }
        }

    }
}
