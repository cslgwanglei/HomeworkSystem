using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Mod;

/// <summary>
///Dadmin 的摘要说明
namespace Dal
{

        public class DAdmin
        {
            #region///检测工号和密码///

            public bool CheckUser(string nNo, string nPass)
            {

                bool IsBool;
                SqlParameter[] paras = { new SqlParameter("@ano", SqlDbType.VarChar, 10), new SqlParameter("@apwd", SqlDbType.VarChar, 50) };
                paras[0].Value = nNo;
                paras[1].Value = nPass;
                string sqlText = "SELECT count(*) FROM [admin] WHERE ano=@ano AND apwd=@apwd ";
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
            public int InsertAdmin(Admin mod)
            {

                int rows;
                SqlParameter[] paras = { 
                                       new SqlParameter("@ano", SqlDbType.VarChar,10),
                                     new SqlParameter("@aname", SqlDbType.VarChar,30),
                                     new SqlParameter("@apwd", SqlDbType.VarChar,50),   
            
            };

                paras[0].Value = mod.Ano;
                paras[1].Value = mod.Aname;
                paras[2].Value = mod.Apwd;
                try
                {

                    rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "InsertAdmin", paras);
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