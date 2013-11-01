using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Mod;
using System.Data.SqlClient;
using System.Data;
namespace Dal
{
    public class DCourse
    {

        #region///添加新数据///
        public int InsertCourse(Course mod)
        {

            int rows;
            SqlParameter[] paras = { 
                                     new SqlParameter("@cname", SqlDbType.VarChar,30),
                                     new SqlParameter("@cinfo", SqlDbType.VarChar,50)  
            
            };
            paras[0].Value = mod.Cname;
            paras[1].Value = mod.Cinfo;

            try
            {

                rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "InsertCourse", paras);
                return rows;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }

        }
        #endregion
        #region///获取所有数据///
        public IList<Course> GetCourse()
        {

            IList<Course> t = new List<Course>();
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectAllCourse", null))
            {
                while (dr.Read())
                {


                    Course mod = new Course(
                                             Convert.ToInt32(dr.GetValue(0)),
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
        public IList<Course> SearchCourse(string cname)
        {

            IList<Course> st = new List<Course>();
            SqlParameter[] paras = { 
                                      
                                      new SqlParameter("@cname", SqlDbType.VarChar,30)};

            paras[0].Value = cname;
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SearchCourse", paras))
            {
                while (dr.Read())
                {


                    Course mod = new Course(
                                             Convert.ToInt32(dr.GetValue(0)),
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