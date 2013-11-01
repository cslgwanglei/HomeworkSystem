using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Dal
{
    public abstract class SQLHelper
    {
        public static readonly string txtConnecttionString = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;


        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, SqlParameter[] cmdParas)
        {

            SqlCommand cmd = new SqlCommand();
            using (SqlConnection con = new SqlConnection(txtConnecttionString))
            {

                PrepareCommand(cmd, con, null, cmdType, cmdText, cmdParas);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;

            }


        }
        public static SqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, SqlParameter[] cmdParas)
        {

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {

                PrepareCommand(cmd, con, null, cmdType, cmdText, cmdParas);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;

            }
            catch (SqlException ex)
            {

                con.Close();
                throw new Exception(ex.Message, ex);

            }
        }

        public static SqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText)
        {

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {

                PrepareCommand(cmd, con, null, cmdType, cmdText);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;

            }
            catch (SqlException ex)
            {

                con.Close();
                throw new Exception(ex.Message, ex);

            }
        }
        public static object ExecuteSclare(string connectionString, CommandType cmdType, string cmdText, SqlParameter[] cmdParas)
        {

            SqlCommand cmd = new SqlCommand();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                PrepareCommand(cmd, con, null, cmdType, cmdText, cmdParas);

                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;

            }

        }
        public static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParas)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = cmdType;

            //当定义cmdParas.Length< 0的时候,在调用该方法时，如果参数为空的话就会报错，错误为“调用的对象可能为空”,所以使用cmdParas!=null

            if (cmdParas != null)
            {

                foreach (SqlParameter para in cmdParas)
                {

                    cmd.Parameters.Add(para);

                }

            }

        }


        //
        public static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = cmdType;

            //当定义cmdParas.Length< 0的时候,在调用该方法时，如果参数为空的话就会报错，错误为“调用的对象可能为空”,所以使用cmdParas!=null



        }
    }
}
