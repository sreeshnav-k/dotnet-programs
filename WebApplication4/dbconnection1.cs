﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication4
{
    public class dbconnection1
    {
        public SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\COMPANY_431013.mdf;Integrated Security=True;Connect Timeout=30;");

        public void execute(SqlCommand cmd)
        {
            cmd.Connection = cn;
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public SqlDataReader getresult(SqlCommand cmd)
        {
            cmd.Connection=cn;
            if(cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            cn.Close();
        }

    }
}