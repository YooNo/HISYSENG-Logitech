using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Data.SqlClient;

namespace HISYSENG_Logitech
{
    public partial class frmLogIn : Form
    {
        string MyMac = "";
        string[] DB_info;
        _DataBase DBSvr = new _DataBase();
        _UserInfo Usr = new _UserInfo();

        SqlDataReader Rs;

        public frmLogIn()
        {
            InitializeComponent();


            // MAC Address 조회
            MyMac = NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString();
        }

        private bool User_LogIn()
        {
            try
            {
                _Query Qry = new _Query();

                Qry.DB_Connect(DBSvr.g_DB_Server, DBSvr.g_DB_NAME, DBSvr.g_DB_ID, DBSvr.g_DB_PWD);

                Rs = Qry.Rs_Query("SELECT C_Code, ID, Name, Dept, mLevel, JobStatus, Phone, Mobile, Mail FROM G_USERS WHERE C_Code = '" +txtCompany_Code.Text + "' AND ID = '" + txtID.Text + "' AND PWD = '" + txtPwd.Text + "'");

                if (Rs.Read())
                {
                    Usr.C_Code = Rs["C_Code"].ToString();
                    Usr.ID = Rs["ID"].ToString();
                    Usr.Name = Rs["Name"].ToString();
                    Usr.Dept = Rs["Dept"].ToString();
                    Usr.mLevel = Rs["mLevel"].ToString();
                    Usr.JobStatus = Rs["JobStatus"].ToString();
                    Usr.Phone = Rs["Phone"].ToString();
                    Usr.Mobile = Rs["Mobile"].ToString();
                    Usr.Mail = Rs["Mail"].ToString();

                    return true;
                }
                else
                {
                    MessageBox.Show("사용자 계정을 찾을 수 없습니다.");

                    return false;
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.ToString());
                return false;
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            try
            {
                #region DB Server 정보 조회

                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("125.129.129.158"), 7482);

                Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                Client.Connect(ipep);

                Byte[] _data = new Byte[1024];

                _data = Encoding.Default.GetBytes(MyMac);
                Client.Send(_data);

                _data = new byte[1024];


                Client.Receive(_data);

                string DB = Encoding.Default.GetString(_data);

                Client.Close();

                #endregion

                #region DB Server 정보 저장

                DB_info = DB.Split('|');

                DBSvr.g_DB_Server = DB_info[0];
                DBSvr.g_DB_ID = DB_info[1];
                DBSvr.g_DB_PWD = DB_info[2].Replace("\0", "");
                DBSvr.g_DB_NAME = "HISYSENG.Cn";

                #endregion
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.ToString());
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            if (User_LogIn())
            {
                frmMain Main = new frmMain(DBSvr, Usr);

                Main.Show();

                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
