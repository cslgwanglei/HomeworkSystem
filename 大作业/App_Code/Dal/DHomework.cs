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
    public class DHomework
    {
        #region///添加新数据///
        public int InsertHomework(Homework mod)
        {

            int rows;
            SqlParameter[] paras = { 
                                     new SqlParameter("@classid", SqlDbType.VarChar ,50),
                                     new SqlParameter("@sno", SqlDbType.VarChar,50)  
            
            };
            paras[0].Value = mod.Classid;
            paras[1].Value = mod.Sno;

            try
            {

                rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "InsertHomework", paras);
                return rows;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }

        }
        #endregion
        #region //更新数据
        public int UpdateHomework(Homework t)
        {

            int rows;
            SqlParameter[] paras = { 
             new SqlParameter("@classid",SqlDbType.VarChar,50),
                 new SqlParameter("@comment", SqlDbType.VarChar,50),
                                   new SqlParameter("@score", SqlDbType.Float ,32),
                                   new SqlParameter("@workname", SqlDbType.VarChar,50),
                                   new SqlParameter("@cname", SqlDbType.VarChar,50),
                                   new SqlParameter("@starttime", SqlDbType.DateTime ,32),
                                   new SqlParameter("@endtime", SqlDbType.DateTime ,32),
                                   new SqlParameter("@hand", SqlDbType.Bit  ,2)
                                   
                                   };
            paras[0].Value = t.Classid;
            paras[1].Value = t.Comment;
            paras[2].Value = t.Score;
            paras[3].Value = t.Workname;
            paras[4].Value = t.Cname;
            paras[5].Value = t.Starttime;
            paras[6].Value = t.Endtime;
            paras[7].Value = t.Hand;
            try
            {

                rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "UpdateHomework", paras);
                return rows;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }
        }
        #endregion
        #region//更新2
         public int UpdateHomework2(Homework t)
        {   int rows;
            SqlParameter[] paras = { 
             new SqlParameter("@hand",SqlDbType.Bit ,2),
             new SqlParameter("@sno",SqlDbType.VarChar,50)
                                   
                                   };
            paras[0].Value = t.Hand;
             paras [1].Value=t.Sno;
         
            try
            {

                rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "UpdateHomework2", paras);
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
