using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Dapper;
namespace Tema
{
    public class DataAccess
    { 
        public List<expe> GetStudents()
        {
            using (IDbConnection conexiune = new SqlConnection(Helper.CnnVal("EX_INFO")))
            {
                return conexiune.Query<expe>("dbo.toti_studenti").AsList();
            }
        }
        public void inserarestud(string nume,int varsta,int An, int Not1 , int Not2, int Not3, int Not4, int Not5)
        {
            using (IDbConnection conexiune = new SqlConnection(Helper.CnnVal("EX_INFO")))
            {
                conexiune.Query("dbo.inserare @name, @age, @an, @not1, @not2, @not3, @not4, @not5", 
                    new{name = nume, age = varsta, an = An, not1 = Not1, not2 = Not2, not3 = Not3, not4 = Not4, not5 = Not5 });
            }
        }
        public void stergere(int Id)
        {
            using (IDbConnection conexiune = new SqlConnection(Helper.CnnVal("EX_INFO")))
            {
                conexiune.Query("dbo.stergere @id", new {id = Id });
            }
        }
        public List<expe> ord_Num(int an)
        {
            using (IDbConnection conexiune = new SqlConnection(Helper.CnnVal("EX_INFO")))
            {
                return conexiune.Query<expe>("dbo.ordNume @cls", new { cls = an }).AsList();
            }
        }
        public List<expe> ord_Med()
        {
            using(IDbConnection conexiune = new SqlConnection(Helper.CnnVal("EX_INFO")))
            {
                return conexiune.Query<expe>("dbo.medie").AsList();
            }
        }
        public List<expe> Anul1()
        {
            using(IDbConnection conexiune = new SqlConnection(Helper.CnnVal("EX_INFO")))
            {
                return conexiune.Query<expe>("dbo.anul1").AsList();
            }
        }
        public List<expe> Anul2()
        {
            using (IDbConnection conexiune = new SqlConnection(Helper.CnnVal("EX_INFO")))
            {
                return conexiune.Query<expe>("dbo.anul2").AsList();
            }
        }
        public List<expe> Anul3()
        {
            using (IDbConnection conexiune = new SqlConnection(Helper.CnnVal("EX_INFO")))
            {
                return conexiune.Query<expe>("dbo.anul3").AsList();
            }
        }
        public List<expe> Anul4()
        {
            using (IDbConnection conexiune = new SqlConnection(Helper.CnnVal("EX_INFO")))
            {
                return conexiune.Query<expe>("dbo.anul4").AsList();
            }
        }
        public List<expe> Caut_Nume(string s)
        {
            using (IDbConnection conexiune = new SqlConnection(Helper.CnnVal("EX_INFO")))
            {
                return conexiune.Query<expe>("dbo.cautNume @Nume", new { Nume = s }).AsList();
            }
        }
    }
}
