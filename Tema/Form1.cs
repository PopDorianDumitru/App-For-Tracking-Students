using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Dapper;
namespace Tema
{
    public partial class Form1 : Form
    {
        List<expe> Students = new List<expe>();
       
      
        public Form1()
        {
            InitializeComponent();
            DataAccess db = new DataAccess();
            Students = db.GetStudents();
            ListStud.ValueMember = "Id";
            ListStud.DisplayMember = "INFO";
            ListStud.DataSource = Students;
        }
       
        Student[] st = new Student[10001];
        int nr = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            /*StreamReader fin = new StreamReader("Studenti.txt");
            string s = fin.ReadLine();
            while(s != null)
            {
                
                ListStud.Items.Add(s);
                string[] arr = s.Split(' ', ',');
                Student x = new Student(arr[0], Convert.ToInt32(arr[2]), Convert.ToInt32(arr[6]));
               
                x.Medie = Convert.ToDouble(arr[9]);
                
                st[nr] = x;
                nr++;
                s = fin.ReadLine();
            }
            fin.Close();*/
        }

        private void AdaugStud_Click(object sender, EventArgs e)
        {
            try
            {
 DataAccess db = new DataAccess();
            int[] nt = new int[5];
            nt[0] = Convert.ToInt32(Not1.Text);
            nt[1] = Convert.ToInt32(Not2.Text);
            nt[2] = Convert.ToInt32(Not3.Text);
            nt[3] = Convert.ToInt32(Not4.Text);
            nt[4] = Convert.ToInt32(Not5.Text);
            db.inserarestud(Numele.Text, Convert.ToInt32(VarstStud.Text), Convert.ToInt32(AnulStud.Text), nt[0], nt[1] , nt[2], nt[3], nt[4]);
            ListStud.DataSource = null;
            ListStud.Items.Clear();
            Students = db.GetStudents();
            ListStud.ValueMember = "Id";
            ListStud.DisplayMember = "INFO";
            ListStud.DataSource = Students;
            }
            catch
            {
                MessageBox.Show("Something must have gone wrong! Please look over the inserted data");
            };
           
            /* if(String.IsNullOrWhiteSpace(Numele.Text))
             {
                 MessageBox.Show("Nu ai introdus numele");
             }
             else
             {
                 int vs = 0, na = 0 , ok = 1;
                 int[] nt = new int[5];
                 try { vs = Convert.ToInt32(VarstStud.Text); }
                 catch { MessageBox.Show("Nu ai introdus Age"); ok = 0; }
                 try { na = Convert.ToInt32(AnulStud.Text); }
                 catch { MessageBox.Show("Nu ai introdus anul din care face parte studentul"); ok = 0; }
                 try
                 {
                     nt[0] = Convert.ToInt32(Not1.Text);
                     nt[1] = Convert.ToInt32(Not2.Text);
                     nt[2] = Convert.ToInt32(Not3.Text);
                     nt[3] = Convert.ToInt32(Not4.Text);
                     nt[4] = Convert.ToInt32(Not5.Text);

                 }
                 catch { MessageBox.Show("Nu ai introdus toate notele"); ok = 0; }
                 if(ok == 1)
                 {
                     Student x = new Student(Numele.Text, vs , na , nt);
                     st[nr++] = x;
                     st[nr - 1].Mediat();
                     StreamWriter fout = new StreamWriter("Studenti.txt" , true);
                     fout.WriteLine(x.AfisareStudent());
                     ListStud.Items.Add(x.AfisareStudent());
                     fout.Close();
                     Numele.Clear();
                     VarstStud.Value = VarstStud.Minimum;
                     Not1.Text = null;
                     Not2.Text = null;
                     Not3.Text = null;
                     Not4.Text = null;
                     Not5.Text = null;
                     AnulStud.Text = null;
                 }
             }*/
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var id = Convert.ToInt32(ListStud.SelectedValue);
            db.stergere(id);
            ListStud.DataSource = null;
            ListStud.Items.Clear();
            Students = db.GetStudents();
            ListStud.ValueMember = "Id";
            ListStud.DisplayMember = "INFO";
            ListStud.DataSource = Students;
            /*if(ListStud.SelectedItem != null)
            {
                nr--;
                StreamReader fin = new StreamReader("Studenti.txt");
                string s = fin.ReadLine(), tt = "",q = ListStud.SelectedItem.ToString();
                while (s != null)
                {
                    if (q != s)
                    {
                        tt += s + "\n";
                    }
                    s = fin.ReadLine();
                }
                fin.Close();
                StreamWriter fout = new StreamWriter("Studenti.txt");
                fout.Write(tt);
                fout.Close();
                ListStud.Items.Remove(ListStud.SelectedItem);
                string[] arr = q.Split(' ', ',');
                int ok = 1;
                for(int i = 0; i <= nr && ok == 1; i++)
                {
                    if(st[i].Nume == arr[0] && st[i].Varsta == Convert.ToInt32(arr[2]) && st[i].An == Convert.ToInt32(arr[6]) && st[i].Medie == Convert.ToDouble(arr[9]))
                    {
                        ok = 0;
                        for (int j = i; j < nr; j++)
                            st[j] = st[j + 1];
                    }
                }
            }*/

        }

        private void OrdNum_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int x = 0;
            try
            {
                x = Convert.ToInt32(OptAn.Text);
            }
            catch { };
            List<expe> dum = new List<expe>();
            dum = db.ord_Num(x);
            ListStud.DataSource = null;
            ListStud.Items.Clear();
            ListStud.ValueMember = "Id";
            ListStud.DisplayMember = "INFO";
            ListStud.DataSource = dum;

            /* for(int i = 0; i < nr - 1; i++)
             {
                 for(int j = i + 1; j < nr; j++)
                 {
                     if(String.Compare(st[i].Nume, st[j].Nume) > 0)
                     {
                         Student aux = st[i];
                         st[i] = st[j];
                         st[j] = aux;
                     }

                 }

             }
             int rn = 0;
             ListStud.Items.Clear();
            for(int i = 0; i < nr; i++)
             {
                 if(OptAn.Text == "" || OptAn.Text == Convert.ToString(st[i].An))
                 ListStud.Items.Add(st[i].AfisareStudent());
             }*/

        }

        private void OrdMed_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int x = 0;
            try
            {
                x = Convert.ToInt32(OptAn.Text);
            }
            catch { };
            List<expe> dum = new List<expe>();
            dum = db.ord_Med();
            ListStud.DataSource = null;
            ListStud.Items.Clear();
            ListStud.ValueMember = "Id";
            ListStud.DisplayMember = "INFO";
            ListStud.DataSource = dum;
            /*for (int i = 0; i < nr - 1; i++)
            {
                for (int j = i + 1; j < nr; j++)
                {
                    if (st[i].Medie > st[j].Medie)
                    {
                        Student aux = st[i];
                        st[i] = st[j];
                        st[j] = aux;
                    }

                }

            }
            int rn = 0;
            ListStud.Items.Clear();
            for (int i = 0; i < nr; i++)
            {
                if (OptAn.Text == "" || OptAn.Text == Convert.ToString(st[i].An))
                    ListStud.Items.Add(st[i].AfisareStudent());
            }
            */
        }

        private void AfisAn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            List<expe> dum = new List<expe>();
            if (OptAn.Text == "")
                dum = db.GetStudents();
            else
                if (OptAn.Text == "1")
                 dum = db.Anul1();
            else
                if (OptAn.Text == "2")
                dum = db.Anul2();
            else
                if (OptAn.Text == "3")
                dum = db.Anul3();
            else
                if (OptAn.Text == "4")
                dum = db.Anul4();
            ListStud.DataSource = null;
            ListStud.Items.Clear();
            ListStud.ValueMember = "Id";
            ListStud.DisplayMember = "INFO";
            ListStud.DataSource = dum;
            /*string s = OptAn.Text;
            if(s == "")
            {
                ListStud.Items.Clear();
                for (int i = 0; i < nr; i++)
                {
                    ListStud.Items.Add(st[i].AfisareStudent());
                }
            }
            else
            {
                ListStud.Items.Clear();
                for(int i = 0; i < nr; i++)
                {
                    if(Convert.ToString(st[i].An) == s)
                        ListStud.Items.Add(st[i].AfisareStudent());
                }
            }*/
        }

        private void Cauta_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            List<expe> dum = new List<expe>();
            dum = db.Caut_Nume(textBox2.Text);
            ListStud.DataSource = null;
            ListStud.Items.Clear();
            ListStud.ValueMember = "Id";
            ListStud.DisplayMember = "INFO";
            ListStud.DataSource = dum;
            /*string s = textBox2.Text;
            ListStud.Items.Clear();
            for (int i = 0; i < nr; i++)
            {
                if (st[i].Nume.Contains(s) && (OptAn.Text == "" || st[i].An == Convert.ToInt32(OptAn.Text)))
                    ListStud.Items.Add(st[i].AfisareStudent());
            }*/
        }
    }
}
