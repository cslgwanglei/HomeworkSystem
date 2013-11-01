using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mod;
using System.Data.SqlClient;
using System.Data;
namespace Dal
{
    public class DGrade
    {
        #region///添加新数据///
        public int InsertGrade(Grade mod)
        {

            int rows;
            SqlParameter[] paras = { 
                                     new SqlParameter("@workname", SqlDbType.VarChar,50),
                                     new SqlParameter("@sno", SqlDbType.VarChar,50), 
                                     new SqlParameter("@cname", SqlDbType.VarChar,50),
                                     new SqlParameter("@score", SqlDbType.VarChar,50), 
                                     new SqlParameter("@comment", SqlDbType.VarChar,50),
                                     new SqlParameter("@workdata", SqlDbType.VarChar,50),
                                     new SqlParameter("@done", SqlDbType.Bit ,2), 
                                     new SqlParameter("@readOnly", SqlDbType.Bit ,2), 
                                     new SqlParameter("@upload", SqlDbType.Bit ,2), 
                                     new SqlParameter("@remark", SqlDbType.Bit ,2),
                                     new SqlParameter ("@classid",SqlDbType.VarChar,50)
            
            };
            paras[0].Value = mod.Workname;
            paras[1].Value = mod.Sno; 
            paras[2].Value = mod.Cname;
            paras[3].Value = mod.Score;
            paras[4].Value = mod.Comment;
            paras[5].Value = mod.Workdata ;
            paras[6].Value = mod.Done;
            paras[7].Value = mod.ReadOnly;
            paras[8].Value = mod.Upload;
            paras[9].Value = mod.Remark;
            paras[10].Value = mod.Classid;
            try
            {

                rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "InsertGrade", paras);
                return rows;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }

        }
        #endregion
        #region///删除数据///
        public bool DeleteGrade(string workname)
        {
            SqlParameter[] paras = { new SqlParameter("@workname", SqlDbType.VarChar ,50) };
            paras[0].Value = workname;
            string sqlText = "DELETE  FROM [grade] WHERE workname=@workname";
            try
            {
                bool i;
                int txtRows = Convert.ToInt32(SQLHelper.ExecuteSclare(SQLHelper.txtConnecttionString, CommandType.Text, sqlText, paras));
                if (txtRows > 0)
                {

                    i = true;

                }
                else
                {

                    i = false;

                }
                return i;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }


        }
        #endregion
        
        #region///更新数据///
        public int UpdateGrade(Grade s)
        {
            int rows;
            SqlParameter[] paras = { 
             new SqlParameter("@workname",SqlDbType.VarChar ,50),
                 new SqlParameter("@sno", SqlDbType.VarChar,50),
                                   new SqlParameter("@cname", SqlDbType.VarChar,50),
                                   new SqlParameter ("@grade",SqlDbType.Float,32),
                                   new SqlParameter("@appraise", SqlDbType.VarChar,50),
                                   new SqlParameter("@remark", SqlDbType.Bit ,2),
                                   new SqlParameter ("@tname",SqlDbType.VarChar,50)
                                   
                                   };
            paras[0].Value =s.Workname  ;
            paras[1].Value = s.Sno ;
            paras[2].Value = s.Cname ;
              paras[3].Value = s.GRade1 ;
            paras[4].Value = s.Appraise ;
            paras[5].Value = s.Remark ;
            paras[6].Value = s.Tname;
            try
            {

                rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "UpdateGrade", paras);
                return rows;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }
        }

    #endregion

        #region///更新数据2///
        public int UpdateGrade2(Grade s)
        {
            int rows;
            SqlParameter[] paras = { 
             new SqlParameter("@workname",SqlDbType.VarChar ,50),
                 new SqlParameter("@sno", SqlDbType.VarChar,50),
                                   new SqlParameter("@cname", SqlDbType.VarChar,50),
                                   new SqlParameter("@done", SqlDbType.Bit ,2)
                                   
                                   };
            paras[0].Value = s.Workname;
            paras[1].Value = s.Sno;
            paras[2].Value = s.Cname;
            paras[3].Value = s.Done ;
            try
            {

                rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "UpdateGrade2", paras);
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