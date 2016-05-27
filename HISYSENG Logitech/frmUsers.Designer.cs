namespace HISYSENG_Logitech
{
    partial class frmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlList = new System.Windows.Forms.Panel();
            this._GrdM = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.txt_S_Name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_S_C_Name = new System.Windows.Forms.TextBox();
            this.btnCompanySearch = new System.Windows.Forms.Button();
            this.txt_S_C_Code = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboJobStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutDate = new System.Windows.Forms.MaskedTextBox();
            this.txtInDate = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtC_Code = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_C_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn조회 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn추가 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn삭제 = new System.Windows.Forms.ToolStripMenuItem();
            this.frmMenu = new System.Windows.Forms.MenuStrip();
            this.btn저장 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn취소 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn창닫기 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GrdM)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.frmMenu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlList);
            this.splitContainer1.Panel1.Controls.Add(this.pnlSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.cboJobStatus);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txtOutDate);
            this.splitContainer1.Panel2.Controls.Add(this.txtInDate);
            this.splitContainer1.Panel2.Controls.Add(this.txtPhone);
            this.splitContainer1.Panel2.Controls.Add(this.txtMail);
            this.splitContainer1.Panel2.Controls.Add(this.txtMobile);
            this.splitContainer1.Panel2.Controls.Add(this.txtPwd);
            this.splitContainer1.Panel2.Controls.Add(this.txtID);
            this.splitContainer1.Panel2.Controls.Add(this.txtC_Code);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.txtName);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.txt_C_Name);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1104, 541);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this._GrdM);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 119);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(384, 418);
            this.pnlList.TabIndex = 4;
            // 
            // _GrdM
            // 
            this._GrdM.AllowUserToDeleteRows = false;
            this._GrdM.AllowUserToOrderColumns = true;
            this._GrdM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._GrdM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._GrdM.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GrdM.Location = new System.Drawing.Point(0, 0);
            this._GrdM.Name = "_GrdM";
            this._GrdM.ReadOnly = true;
            this._GrdM.RowTemplate.Height = 23;
            this._GrdM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._GrdM.Size = new System.Drawing.Size(384, 418);
            this._GrdM.TabIndex = 3;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlSearch.Controls.Add(this.btnUserSearch);
            this.pnlSearch.Controls.Add(this.txt_S_Name);
            this.pnlSearch.Controls.Add(this.label16);
            this.pnlSearch.Controls.Add(this.txt_S_C_Name);
            this.pnlSearch.Controls.Add(this.btnCompanySearch);
            this.pnlSearch.Controls.Add(this.txt_S_C_Code);
            this.pnlSearch.Controls.Add(this.label15);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(384, 119);
            this.pnlSearch.TabIndex = 3;
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserSearch.Location = new System.Drawing.Point(261, 78);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(113, 27);
            this.btnUserSearch.TabIndex = 6;
            this.btnUserSearch.Text = "조회";
            this.btnUserSearch.UseVisualStyleBackColor = true;
            // 
            // txt_S_Name
            // 
            this.txt_S_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_S_Name.Location = new System.Drawing.Point(66, 47);
            this.txt_S_Name.Name = "txt_S_Name";
            this.txt_S_Name.Size = new System.Drawing.Size(307, 22);
            this.txt_S_Name.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 14);
            this.label16.TabIndex = 4;
            this.label16.Text = "사용자";
            // 
            // txt_S_C_Name
            // 
            this.txt_S_C_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_S_C_Name.Location = new System.Drawing.Point(170, 15);
            this.txt_S_C_Name.Name = "txt_S_C_Name";
            this.txt_S_C_Name.ReadOnly = true;
            this.txt_S_C_Name.Size = new System.Drawing.Size(203, 22);
            this.txt_S_C_Name.TabIndex = 3;
            // 
            // btnCompanySearch
            // 
            this.btnCompanySearch.Enabled = false;
            this.btnCompanySearch.Image = global::HISYSENG_Logitech.Properties.Resources.zoom;
            this.btnCompanySearch.Location = new System.Drawing.Point(144, 14);
            this.btnCompanySearch.Name = "btnCompanySearch";
            this.btnCompanySearch.Size = new System.Drawing.Size(26, 27);
            this.btnCompanySearch.TabIndex = 2;
            this.btnCompanySearch.UseVisualStyleBackColor = true;
            // 
            // txt_S_C_Code
            // 
            this.txt_S_C_Code.Location = new System.Drawing.Point(66, 15);
            this.txt_S_C_Code.Name = "txt_S_C_Code";
            this.txt_S_C_Code.ReadOnly = true;
            this.txt_S_C_Code.Size = new System.Drawing.Size(77, 22);
            this.txt_S_C_Code.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "회사";
            // 
            // cboJobStatus
            // 
            this.cboJobStatus.FormattingEnabled = true;
            this.cboJobStatus.Location = new System.Drawing.Point(413, 132);
            this.cboJobStatus.Name = "cboJobStatus";
            this.cboJobStatus.Size = new System.Drawing.Size(134, 22);
            this.cboJobStatus.TabIndex = 15;
            this.cboJobStatus.Tag = "6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "고용구분";
            // 
            // txtOutDate
            // 
            this.txtOutDate.Location = new System.Drawing.Point(413, 167);
            this.txtOutDate.Mask = "####-##-##";
            this.txtOutDate.Name = "txtOutDate";
            this.txtOutDate.Size = new System.Drawing.Size(134, 22);
            this.txtOutDate.TabIndex = 3;
            this.txtOutDate.Tag = "8";
            this.txtOutDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInDate
            // 
            this.txtInDate.Location = new System.Drawing.Point(102, 167);
            this.txtInDate.Mask = "####-##-##";
            this.txtInDate.Name = "txtInDate";
            this.txtInDate.Size = new System.Drawing.Size(165, 22);
            this.txtInDate.TabIndex = 3;
            this.txtInDate.Tag = "7";
            this.txtInDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(413, 204);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(134, 22);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.Tag = "10";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(102, 240);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(590, 22);
            this.txtMail.TabIndex = 10;
            this.txtMail.Tag = "12";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(102, 204);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(165, 22);
            this.txtMobile.TabIndex = 10;
            this.txtMobile.Tag = "11";
            // 
            // txtPwd
            // 
            this.txtPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwd.Location = new System.Drawing.Point(413, 98);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(278, 22);
            this.txtPwd.TabIndex = 8;
            this.txtPwd.Tag = "4";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 98);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(165, 22);
            this.txtID.TabIndex = 6;
            this.txtID.Tag = "3";
            // 
            // txtC_Code
            // 
            this.txtC_Code.Location = new System.Drawing.Point(102, 66);
            this.txtC_Code.Name = "txtC_Code";
            this.txtC_Code.ReadOnly = true;
            this.txtC_Code.Size = new System.Drawing.Size(165, 22);
            this.txtC_Code.TabIndex = 1;
            this.txtC_Code.Tag = "1";
            this.txtC_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(376, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 14);
            this.label13.TabIndex = 1;
            this.label13.Text = "전화";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 132);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 22);
            this.txtName.TabIndex = 4;
            this.txtName.Tag = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 14);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "사용자";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 14);
            this.label11.TabIndex = 1;
            this.label11.Text = "휴대전화";
            // 
            // txt_C_Name
            // 
            this.txt_C_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_C_Name.Location = new System.Drawing.Point(413, 66);
            this.txt_C_Name.Name = "txt_C_Name";
            this.txt_C_Name.ReadOnly = true;
            this.txt_C_Name.Size = new System.Drawing.Size(278, 22);
            this.txt_C_Name.TabIndex = 2;
            this.txt_C_Name.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "회사명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "퇴사 일자";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "입사 일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "회사 코드";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Information";
            // 
            // btn조회
            // 
            this.btn조회.Image = global::HISYSENG_Logitech.Properties.Resources.zoom;
            this.btn조회.Name = "btn조회";
            this.btn조회.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.btn조회.Size = new System.Drawing.Size(84, 20);
            this.btn조회.Text = "조회 (F4)";
            // 
            // btn추가
            // 
            this.btn추가.Image = global::HISYSENG_Logitech.Properties.Resources.add;
            this.btn추가.Name = "btn추가";
            this.btn추가.ShortcutKeyDisplayString = "F2";
            this.btn추가.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.btn추가.Size = new System.Drawing.Size(84, 20);
            this.btn추가.Text = "추가 (F2)";
            // 
            // btn삭제
            // 
            this.btn삭제.Image = global::HISYSENG_Logitech.Properties.Resources.delete;
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.btn삭제.Size = new System.Drawing.Size(105, 20);
            this.btn삭제.Text = "삭제 (Delete)";
            // 
            // frmMenu
            // 
            this.frmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn조회,
            this.btn추가,
            this.btn삭제,
            this.btn저장,
            this.btn취소,
            this.btn창닫기});
            this.frmMenu.Location = new System.Drawing.Point(0, 0);
            this.frmMenu.Name = "frmMenu";
            this.frmMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.frmMenu.Size = new System.Drawing.Size(1104, 24);
            this.frmMenu.TabIndex = 0;
            this.frmMenu.Text = "menuStrip1";
            // 
            // btn저장
            // 
            this.btn저장.Image = global::HISYSENG_Logitech.Properties.Resources.disk;
            this.btn저장.Name = "btn저장";
            this.btn저장.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btn저장.Size = new System.Drawing.Size(113, 20);
            this.btn저장.Text = "저장 (Ctrl + S)";
            // 
            // btn취소
            // 
            this.btn취소.Image = global::HISYSENG_Logitech.Properties.Resources.exclamation;
            this.btn취소.Name = "btn취소";
            this.btn취소.Size = new System.Drawing.Size(59, 20);
            this.btn취소.Text = "취소";
            this.btn취소.Visible = false;
            // 
            // btn창닫기
            // 
            this.btn창닫기.Image = global::HISYSENG_Logitech.Properties.Resources.door_open;
            this.btn창닫기.Name = "btn창닫기";
            this.btn창닫기.Size = new System.Drawing.Size(133, 20);
            this.btn창닫기.Text = "창 닫기 (Ctrl + W)";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.frmMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1104, 29);
            this.pnlMenu.TabIndex = 2;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 570);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsers";
            this.Text = "사용자 관리";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._GrdM)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.frmMenu.ResumeLayout(false);
            this.frmMenu.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DataGridView _GrdM;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.TextBox txt_S_Name;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_S_C_Name;
        private System.Windows.Forms.Button btnCompanySearch;
        private System.Windows.Forms.TextBox txt_S_C_Code;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtC_Code;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_C_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem btn조회;
        private System.Windows.Forms.ToolStripMenuItem btn추가;
        private System.Windows.Forms.ToolStripMenuItem btn삭제;
        private System.Windows.Forms.MenuStrip frmMenu;
        private System.Windows.Forms.ToolStripMenuItem btn저장;
        private System.Windows.Forms.ToolStripMenuItem btn취소;
        private System.Windows.Forms.ToolStripMenuItem btn창닫기;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtInDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboJobStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtOutDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label10;
    }
}