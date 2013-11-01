using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Mod;
namespace Dal{
public class DStudent
{ 
    #region///检测用户名和密码///
     
        public bool CheckUser(string nName, string nPass)
        {

            bool IsBool;
            SqlParameter[] paras = { new SqlParameter("@sno", SqlDbType.VarChar, 50), new SqlParameter("@spwd", SqlDbType.VarChar, 50) };
            paras[0].Value = nName;
            paras[1].Value = nPass;
            string sqlText = "SELECT count(*) FROM [student] WHERE sno=@sno AND spwd=@spwd ";
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
        public int InsertStudent(Student mod)
        {

            int rows;
            SqlParameter[] paras = { new SqlParameter("@sno", SqlDbType.VarChar,50),
                                     new SqlParameter("@sname", SqlDbType.VarChar,50),
                                     new SqlParameter("@classid", SqlDbType.VarChar,50),
                                     new SqlParameter("@spwd", SqlDbType.VarChar,50),   
            
            };
            paras[0].Value = mod.Sno;
            paras[1].Value = mod.Sname;
            paras[2].Value = mod.Sclass;
            paras[3].Value = mod.Spwd;

            try
            {

                rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "InsertStudent", paras);
                return rows;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }

        }
        #endregion
     

}
}