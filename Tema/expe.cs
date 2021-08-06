using System;
using System.Collections.Generic;
using System.Text;

namespace Tema
{
    public class expe
    {
        public int id, classe, age;
        public string name;
        public int id_not, student_id, not1, not2, not3, not4, not5;
        float medie;
        public expe(int Id, string Name, int Class, int Age, int Not1, int Not2, int Not3, int Not4, int Not5)
        {
            id = Id;
            classe = Class;
            age = Age;
            name = Name;
            not1 = Not1;
            not2 = Not2;
            not3 = Not3;
            not4 = Not4;
            not5 = Not5;
        }
        public void note(int Id_not, int Student_id,int Not1,int Not2,int Not3,int Not4,int Not5)
        {
            id_not = Id_not;
            student_id = Student_id;
            not1 = Not1;
            not2 = Not2;
            not3 = Not3;
            not4 = Not4;
            not5 = Not5;
        }
        public double Medie()
        {
            return Math.Round((this.not1 + this.not2 + this.not3 + this.not4 + this.not5) / 5.0,2);
        }
        public string INFO { get {
                
                return $"{this.name}, {this.age} ani, anul {this.classe}, medie {this.Medie()}";
            } }
        public int Id { get { return this.id; } }

    }
}
