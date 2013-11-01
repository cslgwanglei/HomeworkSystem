using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Mod;
namespace Dal
{
    public class DTeacher
    {
        #region///检测用户名和密码///

        public bool CheckUser(string nName, string nPass)
        {

            bool IsBool;
            SqlParameter[] paras = { new SqlParameter("@tno", SqlDbType.VarChar, 10), new SqlParameter("@tpwd", SqlDbType.VarChar, 50) };
            paras[0].Value = nName;
            paras[1].Value = nPass;
            string sqlText = "SELECT count(*) FROM [teacher] WHERE tno=@tno AND tpwd=@tpwd ";
            try
            {

                int txtRows = int.Parse(SQLHelper.ExecuteSclare(SQLHelper.txtConnecttionString, CommandType.Text, sqlText, paras).ToString());
                if (txtRows > 0)
                {

                    IsBool = true;

                }
                else
                {

                    IsBool = false;

                }
                return IsBool;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }

        }
        #endregion
        #region///添加新数据///
        public int InsertTeacher(Teacher mod)
        {

            int rows;
            SqlParameter[] paras = { new SqlParameter("@tno", SqlDbType.VarChar,30),
                                     new SqlParameter("@tname", SqlDbType.VarChar,30),
                                     new SqlParameter("@tpwd", SqlDbType.VarChar,50),   
            
            };
            paras[0].Value = mod.Tno;
            paras[1].Value = mod.Tname;
            paras[2].Value = mod.Tpwd;

            try
            {

                rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "InsertTeacher", paras);
                return rows;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }

        }
        #endregion
        #region///获取所有数据///
        public IList<Teacher> GetTeacher()
        {

            IList<Teacher> t = new List<Teacher>();
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectAllTeacher", null))
            {
                while (dr.Read())
                {


                    Teacher mod = new Teacher(
                                             Convert.ToString(dr.GetValue(0)),
                                             Convert.ToString(dr.GetValue(1)),
                                             Convert.ToString(dr.GetValue(2))
                                             );
                    t.Add(mod);
                }


            }
            return t;
        }
        #endregion
        #region///查询数据///
        public IList<Teacher> SearchTeacher(string tno, string tname)
        {

            IList<Teacher> st = new List<Teacher>();
            SqlParameter[] paras = { 
                                      new SqlParameter("@tno", SqlDbType.VarChar,30),
                                      new SqlParameter("@tname", SqlDbType.VarChar,30)};
            paras[0].Value = tno;
            paras[1].Value = tname;
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SearchTeacher", paras))
            {
                while (dr.Read())
                {


                    Teacher mod = new Teacher(
                                             Convert.ToString(dr.GetValue(0)),
                                             Convert.ToString(dr.GetValue(1)),
                                             Convert.ToString(dr.GetValue(2)));
                    st.Add(mod);
                }


            }
            return st;
        }
        #endregion

    }
}