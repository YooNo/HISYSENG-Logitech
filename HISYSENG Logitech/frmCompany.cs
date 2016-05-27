using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace HISYSENG_Logitech
{
    public partial class frmCompany : Form
    {
        _DataBase _DB = new _DataBase();
        _UserInfo _Usr = new _UserInfo();
        _Query Qry = new _Query();

        hGrid grd = new hGrid();

        DataGridViewRow actRow;

        string _SQL = string.Empty;
        string _C_Code = string.Empty;

        #region Form Initialize

        private void FormClose(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public frmCompany(object DB_Info, object Usr)
        {
            InitializeComponent();

            _DB = (_DataBase)DB_Info;
            _Usr = (_UserInfo) Usr;

            Qry.DB_Connect(_DB.g_DB_Server, _DB.g_DB_NAME, _DB.g_DB_ID, _DB.g_DB_PWD);

            btn창닫기.Click += new EventHandler(FormClose);
            btn조회.Click += new EventHandler(Company_Search);
            btn추가.Click += new EventHandler(Company_ADD);
            btn취소.Click += new EventHandler(Company_Cancel);
            btn삭제.Click += new EventHandler(Company_Delete);
            btn저장.Click += new EventHandler(Company_Save);
        }


        private void frmCompany_Load(object sender, EventArgs e)
        {
            try
            {
                #region 그리드 조회, 세팅

                pnlMenu.Visible = false;

                grd.Init(_GrdM);

                GrdSearch();

                GrdSetting();

                #endregion

                #region 그리드 액션 추가

                // 여기에서 이벤트를 등록하면 데이터 조회/세팅시 발생하는 오류를 없앨 수 있다.

                _GrdM.SelectionChanged += new EventHandler(GrdSelect);

                #endregion
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #endregion

        #region User method

        private void Company_Search(object sender, EventArgs e)
        {
            GrdSearch();

        }

        private void Company_ADD(object sender, EventArgs e)
        {
            _GrdM.Enabled = false;
            btn삭제.Enabled = false;
            btn조회.Enabled = false;
            btn취소.Visible = true;

            txtInit();

            txtC_Code.ReadOnly = false;
        }

        private void Company_Cancel(object sender, EventArgs e)
        {
            _GrdM.Enabled = true;
            btn삭제.Enabled = true;
            btn조회.Enabled = true;
            btn취소.Visible = false;

            txtInit();

            txtC_Code.ReadOnly = true;
        }

        private void Company_Delete(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("회사를 삭제하시겠습니까?", "회사 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (actRow != null)
                    {
                        if (Qry.Rs_NonQuery("DELETE G_COMPANY WHERE C_CODE = '" + actRow.Cells["C_Code"].Value.ToString() + "'"))
                        {
                            GrdSearch();

                            MessageBox.Show("삭제되었습니다.");
                        }
                        else
                        {
                            MessageBox.Show("삭제도중 오류가 발생했습니다.");
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Company_Save(object sender, EventArgs e)
        {
            if (btn취소.Visible)
            {
                #region 데이터 추가

                try
                {
                    string[,] Values = new string[100, 2];

                    int Idx = 0;

                    #region 컨트롤 값 배열 세팅

                    foreach (Control ctl in splitContainer1.Panel2.Controls)
                    {
                        if (typeof(System.Windows.Forms.TextBox) == ctl.GetType() || typeof(System.Windows.Forms.MaskedTextBox) == ctl.GetType())
                        {
                            Values[int.Parse(ctl.Tag.ToString()), 0] = ctl.Text.Replace("'", "");
                            Values[int.Parse(ctl.Tag.ToString()), 1] = ctl.Tag.ToString();

                            if (int.Parse(ctl.Tag.ToString()) > Idx)
                                Idx = int.Parse(ctl.Tag.ToString());
                        }
                    }

                    #endregion


                    #region 쿼리 생성 및 실행

                    for (int i = 1; i <= Idx; i++)
                    {
                        if (i == 1)
                        {
                            _SQL = "N'" + Values[i, 0] + "'";
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(Values[i, 0]))
                                _SQL += ",''";
                            else
                                _SQL += ", N'" + Values[i, 0] + "'";
                        }
                    }

                    _SQL = "INSERT INTO G_COMPANY VALUES (" + _SQL + ")";
                    if (!Qry.Rs_NonQuery(_SQL))
                    {
                        MessageBox.Show("거래처 추가 중 에러가 발생했습니다.");
                        return;
                    }

                    #endregion

                    MessageBox.Show("거래처가 추가되었습니다.");

                    #region 컨트롤 복구, 데이터 조회

                    _GrdM.Enabled = true;
                    btn삭제.Enabled = true;
                    btn조회.Enabled = true;
                    btn취소.Visible = false;

                    txtC_Code.ReadOnly = true;

                    GrdSearch();

                    #endregion

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                #endregion
            }
            else
            {
                #region 데이터 Update

                try
                {

                    #region 컨트롤 값 배열 세팅

                    _SQL = "";

                    foreach (Control ctl in splitContainer1.Panel2.Controls)
                    {
                        if (typeof(System.Windows.Forms.TextBox) == ctl.GetType() || typeof(System.Windows.Forms.MaskedTextBox) == ctl.GetType())
                        {
                            if (string.IsNullOrEmpty(_SQL))
                            {
                                _SQL = ctl.Name.Replace("txt", "") + " = N'" + ctl.Text + "' ";
                            }
                            else
                            {
                                _SQL += ", " + ctl.Name.Replace("txt", "") + " = N'" + ctl.Text + "' ";
                            }
                        }
                    }
                    
                    #endregion


                    #region 쿼리 생성 및 실행


                    _SQL = "UPDATE G_COMPANY SET " + _SQL;

                    if (string.IsNullOrEmpty(_C_Code))
                    {
                        MessageBox.Show("변경할 회사가 선택되지 않았습니다.");
                        return;
                    }

                    _SQL += " WHERE C_CODE = '" + _C_Code + "'";

                    if (!Qry.Rs_NonQuery(_SQL))
                    {
                        MessageBox.Show("거래처 업데이트 중 에러가 발생했습니다.");
                        return;
                    }

                    #endregion

                    MessageBox.Show("거래처가 저장되었습니다.");


                    #region 데이터 조회

                    GrdSearch();

                    #endregion

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                #endregion
            }
        }

        private void txtInit()
        {
            foreach (Control ctl in splitContainer1.Panel2.Controls)
            {
                if (typeof(System.Windows.Forms.TextBox) == ctl.GetType())
                {
                    ctl.Text = string.Empty;
                }

                if (typeof(System.Windows.Forms.MaskedTextBox) == ctl.GetType())
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void GrdSelect(object sender, EventArgs e)
        {
            if (_GrdM.SelectedRows.Count != 0)
            {
                actRow = _GrdM.SelectedRows[0];

                txtC_Code.Text = actRow.Cells["C_Code"].Value.ToString();
                txtC_Name.Text = actRow.Cells["C_Name"].Value.ToString();
                txtFDate.Text = actRow.Cells["FDate"].Value.ToString();
                txtDName.Text = actRow.Cells["DName"].Value.ToString();
                txtZipCode.Text = actRow.Cells["ZipCode"].Value.ToString();
                txtAddress.Text = actRow.Cells["Address"].Value.ToString();
                txtSNo.Text = actRow.Cells["SNo"].Value.ToString();
                txtPNo.Text = actRow.Cells["PNo"].Value.ToString();
                txtUpTae.Text = actRow.Cells["UpTae"].Value.ToString();
                txtJong.Text = actRow.Cells["Jong"].Value.ToString();
                txtPhone.Text = actRow.Cells["Phone"].Value.ToString();
                txtFax.Text = actRow.Cells["Fax"].Value.ToString();
                txtDC_Rmk.Text = actRow.Cells["DC_Rmk"].Value.ToString();

                txtC_Code.ReadOnly = true;

                _C_Code = txtC_Code.Text;
            }
        }

        private void GrdSetting()
        {
            grd.SetCol(_GrdM, "C_Code", "회사", 100, true);
            grd.SetCol(_GrdM, "C_NAME", "회사명", 200, true);
            grd.SetCol(_GrdM, "FDate", "", 0, false);
            grd.SetCol(_GrdM, "TDate", "", 0, false);
            grd.SetCol(_GrdM, "DName", "", 0, false);
            grd.SetCol(_GrdM, "ZipCode", "", 0, false);
            grd.SetCol(_GrdM, "Address", "", 0, false);
            grd.SetCol(_GrdM, "SNo", "", 0, false);
            grd.SetCol(_GrdM, "PNo", "", 0, false);
            grd.SetCol(_GrdM, "UpTae", "", 0, false);
            grd.SetCol(_GrdM, "Jong", "", 0, false);
            grd.SetCol(_GrdM, "Phone", "", 0, false);
            grd.SetCol(_GrdM, "Fax", "", 0, false);
            grd.SetCol(_GrdM, "DC_Rmk", "", 0, false);


            grd.AlignCenter(_GrdM, "C_Code");
            grd.AlignLeft(_GrdM, "C_Name");
            grd.HeaderAlignment(_GrdM);
        }

        private void GrdSearch()
        {
            DataTable Tbl = new DataTable();

            Tbl = Qry.Tbl_Query("SELECT * FROM G_COMPANY");

            _GrdM.DataSource = Tbl;
        }

        #endregion
    }
}
