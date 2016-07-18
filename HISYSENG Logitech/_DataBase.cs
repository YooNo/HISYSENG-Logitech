using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HISYSENG_Logitech
{   
    class _DataBase
    {
        string DB_Server, DB_ID, DB_PWD, DB_NAME;

        public string g_DB_Server {
            set
            {
                DB_Server = value;
            }
            get {
                return DB_Server;
            }
        }

        public string g_DB_ID
        {
            set
            {
                DB_ID = value;
            }
            get
            {
                return DB_ID;
            }
        }

        public string g_DB_PWD
        {
            set
            {
                DB_PWD = value;
            }
            get
            {
                return DB_PWD;
            }
        }

        public string g_DB_NAME
        {
            set
            {
                DB_NAME = value;
            }
            get
            {
                return DB_NAME;
            }
        }
    }

    class _Query
    {

        SqlConnection Cn;
        SqlCommand Cmd;
        SqlDataReader Rs, Rs_tmp;
        SqlTransaction Trn;
        SqlDataAdapter Adt;
        DataTable Tbl;

        string ConnectionString = "";
        string ID, Pwd, Svr, SvrIP;


        public bool BeginTran()
        {
            try
            {
                Trn = Cn.BeginTransaction();

                Cmd.Transaction = Trn;

                return true;
            }
            catch (Exception Err)
            {
                return false;
            }
        }

        public bool CommitTrn()
        {
            try
            {
                Trn.Commit();

                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        public bool RollBack()
        {
            try
            {
                Trn.Rollback();

                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        /// <summary>
        /// DB Connection
        /// </summary>
        public bool DB_Connect(string Server, string DB, string ID, string Pwd)
        {
            try {
                ConnectionString = @"Data Source=" + Server + ";User ID=" + ID + ";Password="+ Pwd + ";Initial Catalog=" + DB + ";MultipleActiveResultSets=True";
                Cn = new SqlConnection(ConnectionString);
                Cn.Open();

                Cmd = new SqlCommand();
                Cmd.Connection = Cn;

                return true;
            }
            catch (Exception Err)
            {
                return false;
            }
        }

        public DataTable Tbl_Query(string Query)
        {
            try
            {
                Adt = new SqlDataAdapter(Query, Cn);

                Tbl = new DataTable();
                Adt.Fill(Tbl);

                return Tbl;
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
                return null;
            }
        }

        public SqlDataReader Rs_Query(string Query)
        {
            try
            {

                Cmd.CommandText = Query;
                Cmd.CommandType = System.Data.CommandType.Text;

                //Rs_tmp = Rs;
                Rs_tmp = Cmd.ExecuteReader();

                return Rs_tmp;
            }
            catch (Exception Err)
            {
                return null;
            }
        }

        public bool Rs_NonQuery(string Query)
        {
            bool LocalTran = false;


            try
            {
                if (Trn == null)
                {

                    LocalTran = true;

                    Trn = Cn.BeginTransaction();
                    Cmd.Transaction = Trn;
                }



                Cmd.CommandText = Query;
                Cmd.CommandType = System.Data.CommandType.Text;

                Cmd.ExecuteNonQuery();



                if (LocalTran == true)
                    Trn.Commit();

                return true;
            }
            catch (Exception Err)
            {
                if (LocalTran == true)
                    Trn.Rollback();

                MessageBox.Show(Err.Message);

                return false;
            }
        }
    }

    class _UserInfo
    {
        string id, name, c_code, c_name, dept, mlevel, jobstatus, phone, mobile, mail;

        public string ID
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string C_Code
        {
            set
            {
                c_code = value;
            }
            get
            {
                return c_code;
            }
        }

        public string C_Name
        {
            set
            {
                c_name = value;
            }
            get
            {
                return c_name;
            }
        }

        public string Dept
        {
            set
            {
                dept = value;
            }
            get
            {
                return dept;
            }
        }

        public string mLevel
        {
            set
            {
                mlevel = value;
            }
            get
            {
                return mlevel;
            }
        }

        public string JobStatus
        {
            set
            {
                jobstatus = value;
            }
            get
            {
                return jobstatus;
            }
        }

        public string Phone
        {
            set
            {
                phone = value;
            }
            get
            {
                return phone;
            }
        }

        public string Mobile
        {
            set
            {
                mobile = value;
            }
            get
            {
                return mobile;
            }
        }

        public string Mail
        {
            set
            {
                mail = value;
            }
            get
            {
                return mail;
            }
        }
    }
}
