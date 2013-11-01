using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mod;
using System.Data.SqlClient;
using System.Data;
namespace Dal
{
    public class DWork
    {
        #region ///添加数据///
        public int InsertWork(Work mod)
        {
            int rows;
            SqlParameter[] paras = { new SqlParameter("@workname", SqlDbType.VarChar,50),
                                     
                                     new SqlParameter("@starttime", SqlDbType.DateTime,8),
                                   
                                      new SqlParameter("@tip", SqlDbType.Bit ,2),
                                     new SqlParameter("@comment", SqlDbType.VarChar,50),
                                      new SqlParameter ("@score",SqlDbType.Float,5),
                                        new SqlParameter ("@readOnly",SqlDbType.Bit,2),
                                        new SqlParameter ("@cname",SqlDbType.VarChar,50),
                                     
                                
            
            };
            paras[0].Value = mod.Name;
            paras[1].Value = mod.Start;
         
            paras[2].Value = mod.Tip;
            paras[3].Value = mod.Comment;
            paras[4].Value = mod.Score;
            paras[5].Value = mod.ReadOnly;
            paras[6].Value = mod.Cname;
           


            try
            {

                rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "InsertWork", paras);
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
