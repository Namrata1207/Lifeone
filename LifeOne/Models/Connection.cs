﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace LifeOne.Models
{
    public class Connection
    {
        public static string connectionString = string.Empty;
        public static string connectionString1 = string.Empty;
        static Connection()
        {
            try
            {

                connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ToString();


            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int ExecuteNonQuery(string commandText, params SqlParameter[] commandParameters)
        {
            int k = 0;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(commandParameters);
                    connection.Open();
                    k = command.ExecuteNonQuery();
                }
                return k;
            }
            catch
            {
                return k;
            }
        }

        public static DataSet ExecuteQuery(string commandText, params SqlParameter[] parameters)
        {
            DataSet ds = new DataSet();
            try
            {


                var connection = new SqlConnection(connectionString);
                var command = new SqlCommand(commandText, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);
                connection.Close();



            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Flag");
                dt.Columns.Add("Message");

                DataRow dr = dt.NewRow();
                dr["Flag"] = "0";
                dr["Message"] = ex.Message;
                dt.Rows.Add(dr);
                ds.Tables.Add(dt);

            }
            return ds;
        }

        public static DataSet ExecuteQueryFamilyn(string commandText, params SqlParameter[] parameters)
        {
            DataSet ds = new DataSet();
            try
            {


                 var connection = new SqlConnection(connectionString1);
                 var command = new SqlCommand(commandText, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);
                connection.Close();



            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Flag");
                dt.Columns.Add("Message");

                DataRow dr = dt.NewRow();
                dr["Flag"] = "0";
                dr["Message"] = ex.Message;
                dt.Rows.Add(dr);
                ds.Tables.Add(dt);

            }
            return ds;
        }


    }
}
