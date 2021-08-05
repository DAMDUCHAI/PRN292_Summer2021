using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Q2.DAO
{
    class Courses
    {
        private string code;
        private string descripton;
        private int sub;
        private int instruc;

        public string Code { get => code; set => code = value; }
        public string Descripton { get => descripton; set => descripton = value; }
        public int Sub { get => sub; set => sub = value; }
        public int Instruc { get => instruc; set => instruc = value; }

        public Courses(string code, string descripton, int sub, int instruc)
        {
            this.code = code;
            this.descripton = descripton;
            this.sub = sub;
            this.instruc = instruc;
        }
        public Courses()
        {
        
        }
        public int AddCourse(ArrayList arrayList)
        {
            string sql = "INSERT INTO [dbo].[COURSES] VALUES (@code , @descrip, @sub,@instruc,null,null)";
            SqlParameter[] para = new SqlParameter[] {
            new SqlParameter("@code", SqlDbType.NVarChar),
            new SqlParameter("@descrip", SqlDbType.NVarChar),
            new SqlParameter("@sub", SqlDbType.Int),
            new SqlParameter("@instruc", SqlDbType.Int)
            };
            //Gán giá trị cho các tham số của câu truy vấn
            for (int i = 0; i < arrayList.Count; i++)
            {
                para[i].Value = arrayList[i];
            }
            return Database.ExcuteSQL(sql, para);
        }

    }
}
