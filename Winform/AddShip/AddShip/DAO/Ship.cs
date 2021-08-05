using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AddShip.DAO
{
    class Ship
    {
        private string name;
        private string classs;
        private int launched;

        public string Name { get => name; set => name = value; }
        public string Classs { get => classs; set => classs = value; }
        public int Launched { get => launched; set => launched = value; }

        public Ship(string name, string classs, int launched)
        {
            this.name = name;
            this.classs = classs;
            this.launched = launched;
        }
        public Ship()
        {
            
        }



        // thuc hanh nghiep vu
        internal static int AddShip(ArrayList arrayList)
        {
            string sql = "INSERT INTO Ships VALUES (@name , @class, @launched)";
            SqlParameter[] para = new SqlParameter[] {
            new SqlParameter("@name", SqlDbType.NChar),
            new SqlParameter("@class", SqlDbType.NChar),
            new SqlParameter("@launched", SqlDbType.Int)
            };
            //Gán giá trị cho các tham số của câu truy vấn
            for (int i = 0; i < arrayList.Count; i++)
            {
                para[i].Value = arrayList[i];
            }
            return Database.ExcuteSQL(sql, para);
        }


        internal static List<string> GetNameShip()
        {
            List<string> name = new List<string>();
            DataTable dataTable = Database.GetDataBySQL("select name from Ships");
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string n = dataRow["name"].ToString();


                name.Add(n);
            }
            return name;


        }
        internal static List<string> GetClass()
        {
            List<string> classs = new List<string>();
            DataTable dataTable = Database.GetDataBySQL("select class from Classes");
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string c = dataRow["class"].ToString();

                classs.Add(c);
            }
            return classs;


        }


    }
}
