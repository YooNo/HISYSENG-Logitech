using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HISYSENG_Logitech
{
    public partial class frmMain : Form
    {
        _DataBase _DB = new _DataBase();
        _UserInfo _Usr  = new _UserInfo();

        Form objForm = new Form();

        #region Form Action

        public frmMain(object DB_Info, object Usr)
        {
            InitializeComponent();

            _DB = (_DataBase) DB_Info;
            _Usr = (_UserInfo) Usr;

            lblUser.Text = _Usr.Name + " [" + _Usr.ID + "]";
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
                Application.Exit();
            }
        }

        #endregion

        #region User Method

        private bool ActiveFormCheck(string frmName)
        {
            foreach (System.Windows.Forms.Form frmX in this.MdiChildren)
            {
                if (frmX.Name == frmName)
                {
                    frmX.Activate();

                    return false;
                }
            }
            return true;
        }

        private bool ActiveFormCheck(Form frmObj)
        {
            foreach (System.Windows.Forms.Form frmX in this.MdiChildren)
            {
                if (frmX.Name == frmObj.Name)
                {
                    frmX.Activate();

                    return false;
                }
            }
            return true;
        }

        private void objForm_Show()
        {
            if (!ActiveFormCheck(objForm))
            {
                objForm = null;
                return;
            }

            objForm.MdiParent = this;

            g_Menu.SuspendLayout();

            objForm.WindowState = FormWindowState.Maximized;

            objForm.Show();

            g_Menu.Visible = false;
            g_Menu.Visible = true;
            g_Menu.ResumeLayout(); 
        }

        #endregion

        #region Control Event

        private void btn회사관리_Click(object sender, EventArgs e)
        {
            objForm = new frmCompany(_DB, _Usr);
            objForm_Show();
        }

        private void btn사용자관리_Click(object sender, EventArgs e)
        {
            objForm = new frmUsers(_DB, _Usr);
            objForm_Show();
        }

        #endregion


    }
}
