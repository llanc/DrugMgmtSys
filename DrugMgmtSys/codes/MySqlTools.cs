using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugMgmtSys.codes
{
    class MySqlTools
    {
        //从web.config连接字符串
        private static readonly string mySqlConStr = ConfigurationManager.ConnectionStrings["mySqlConStr"].ConnectionString;//ConfigurationManager.ConnectionStrings["mySqlConStr"].ConnectionString;

        //增删改 ExecuteNonQuery()
        /// <summary>
        /// 受影响的行数 inset，delete，update
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="pms">可变数组</param>
        /// <returns>int</returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] pms)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(mySqlConStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, mySqlCon))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    mySqlCon.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 单行查询 返回结果中的第一行第一列 
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="pms">可变数组</param>
        /// <returns>object</returns>
        public static object ExecuteScalar(string sql, params MySqlParameter[] pms)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(mySqlConStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, mySqlCon))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    mySqlCon.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// 多行查询
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="pms">可变数组</param>
        /// <returns>MySqlDataReader</returns>
        public static MySqlDataReader ExecuteReader(string sql, params MySqlParameter[] pms)
        {
            MySqlConnection mySqlCon = new MySqlConnection(mySqlConStr);
            using (MySqlCommand cmd = new MySqlCommand(sql, mySqlCon))
            {
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    mySqlCon.Open();
                    //枚举参数 System.Data.CommandBehavior.CloseConnection 在MySqlDataReader使用完毕后，在关闭MySqlDataReader的同时会将其内部关联的Connection对象也关闭
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch//Sql语句错误时关闭连接
                {
                    mySqlCon.Close();
                    mySqlCon.Dispose();
                    throw;
                }

            }
        }
        /// <summary>
        /// 获取DataSet
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="pms">可变数组</param>
        /// <returns>DataSet</returns>
        public static DataSet GetDataSet(string sql, params MySqlParameter[] pms)
        {
            MySqlConnection mySqlCon = new MySqlConnection(mySqlConStr);
            using (MySqlCommand cmd = new MySqlCommand(sql, mySqlCon))
            {
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    mySqlCon.Open();
                    MySqlDataAdapter myDataAdpter = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    myDataAdpter.Fill(ds);
                    return ds;
                }
                catch//Sql语句错误时关闭连接
                {
                    mySqlCon.Close();
                    mySqlCon.Dispose();
                    throw;
                }
            }
        }
    }
}
