namespace HISYSENG_Logitech
{
    partial class frmCompany
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompany));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._GrdM = new System.Windows.Forms.DataGridView();
            this.txtSNo = new System.Windows.Forms.MaskedTextBox();
            this.txtFDate = new System.Windows.Forms.MaskedTextBox();
            this.txtDC_Rmk = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPNo = new System.Windows.Forms.TextBox();
            this.txtJong = new System.Windows.Forms.TextBox();
            this.txtUpTae = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtC_Code = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtC_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.frmMenu = new System.Windows.Forms.MenuStrip();
            this.btn조회 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn추가 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn삭제 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn저장 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn취소 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn창닫기 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GrdM)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.frmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._GrdM);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.txtSNo);
            this.splitContainer1.Panel2.Controls.Add(this.txtFDate);
            this.splitContainer1.Panel2.Controls.Add(this.txtDC_Rmk);
            this.splitContainer1.Panel2.Controls.Add(this.txtFax);
            this.splitContainer1.Panel2.Controls.Add(this.txtPhone);
            this.splitContainer1.Panel2.Controls.Add(this.txtPNo);
            this.splitContainer1.Panel2.Controls.Add(this.txtJong);
            this.splitContainer1.Panel2.Controls.Add(this.txtUpTae);
            this.splitContainer1.Panel2.Controls.Add(this.txtZipCode);
            this.splitContainer1.Panel2.Controls.Add(this.txtC_Code);
            this.splitContainer1.Panel2.Controls.Add(this.txtAddress);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.txtDName);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.txtC_Name);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1136, 626);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 1;
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
            this._GrdM.Size = new System.Drawing.Size(399, 622);
            this._GrdM.TabIndex = 2;
            // 
            // txtSNo
            // 
            this.txtSNo.Location = new System.Drawing.Point(89, 128);
            this.txtSNo.Mask = "###-##-#####";
            this.txtSNo.Name = "txtSNo";
            this.txtSNo.Size = new System.Drawing.Size(145, 20);
            this.txtSNo.TabIndex = 5;
            this.txtSNo.Tag = "8";
            this.txtSNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFDate
            // 
            this.txtFDate.Location = new System.Drawing.Point(89, 93);
            this.txtFDate.Mask = "####-##-##";
            this.txtFDate.Name = "txtFDate";
            this.txtFDate.Size = new System.Drawing.Size(145, 20);
            this.txtFDate.TabIndex = 3;
            this.txtFDate.Tag = "3";
            this.txtFDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDC_Rmk
            // 
            this.txtDC_Rmk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDC_Rmk.Location = new System.Drawing.Point(89, 317);
            this.txtDC_Rmk.Multiline = true;
            this.txtDC_Rmk.Name = "txtDC_Rmk";
            this.txtDC_Rmk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDC_Rmk.Size = new System.Drawing.Size(626, 295);
            this.txtDC_Rmk.TabIndex = 13;
            this.txtDC_Rmk.Tag = "14";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(89, 271);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(145, 20);
            this.txtFax.TabIndex = 12;
            this.txtFax.Tag = "13";
            this.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(361, 236);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(145, 20);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.Tag = "12";
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPNo
            // 
            this.txtPNo.Location = new System.Drawing.Point(89, 236);
            this.txtPNo.Name = "txtPNo";
            this.txtPNo.Size = new System.Drawing.Size(145, 20);
            this.txtPNo.TabIndex = 10;
            this.txtPNo.Tag = "9";
            this.txtPNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJong
            // 
            this.txtJong.Location = new System.Drawing.Point(361, 202);
            this.txtJong.Name = "txtJong";
            this.txtJong.Size = new System.Drawing.Size(145, 20);
            this.txtJong.TabIndex = 9;
            this.txtJong.Tag = "11";
            this.txtJong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUpTae
            // 
            this.txtUpTae.Location = new System.Drawing.Point(89, 199);
            this.txtUpTae.Name = "txtUpTae";
            this.txtUpTae.Size = new System.Drawing.Size(145, 20);
            this.txtUpTae.TabIndex = 8;
            this.txtUpTae.Tag = "10";
            this.txtUpTae.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(89, 164);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(145, 20);
            this.txtZipCode.TabIndex = 6;
            this.txtZipCode.Tag = "6";
            this.txtZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC_Code
            // 
            this.txtC_Code.Location = new System.Drawing.Point(89, 57);
            this.txtC_Code.Name = "txtC_Code";
            this.txtC_Code.Size = new System.Drawing.Size(145, 20);
            this.txtC_Code.TabIndex = 1;
            this.txtC_Code.Tag = "1";
            this.txtC_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(361, 160);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(354, 20);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.Tag = "7";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "비고";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "주소";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Fax";
            // 
            // txtDName
            // 
            this.txtDName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDName.Location = new System.Drawing.Point(361, 93);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(354, 20);
            this.txtDName.TabIndex = 4;
            this.txtDName.Tag = "5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(302, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "전화번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "대표자";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "휴대전화";
            // 
            // txtC_Name
            // 
            this.txtC_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtC_Name.Location = new System.Drawing.Point(361, 57);
            this.txtC_Name.Name = "txtC_Name";
            this.txtC_Name.Size = new System.Drawing.Size(354, 20);
            this.txtC_Name.TabIndex = 2;
            this.txtC_Name.Tag = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "업종";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "사업자 번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "업태";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "회사명";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "우편 번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "등록 일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "회사 코드";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Information";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "zoom.png");
            this.imageList1.Images.SetKeyName(1, "add.png");
            this.imageList1.Images.SetKeyName(2, "delete.png");
            this.imageList1.Images.SetKeyName(3, "disk.png");
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.frmMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1136, 25);
            this.pnlMenu.TabIndex = 0;
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
            this.frmMenu.Size = new System.Drawing.Size(1136, 24);
            this.frmMenu.TabIndex = 0;
            this.frmMenu.Text = "menuStrip1";
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
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 651);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Verdana", 8F);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.frmMenu;
            this.Name = "frmCompany";
            this.Text = "회사 관리";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._GrdM)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.frmMenu.ResumeLayout(false);
            this.frmMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MaskedTextBox txtSNo;
        private System.Windows.Forms.MaskedTextBox txtFDate;
        private System.Windows.Forms.TextBox txtDC_Rmk;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPNo;
        private System.Windows.Forms.TextBox txtJong;
        private System.Windows.Forms.TextBox txtUpTae;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtC_Code;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtC_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _GrdM;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.MenuStrip frmMenu;
        private System.Windows.Forms.ToolStripMenuItem btn조회;
        private System.Windows.Forms.ToolStripMenuItem btn추가;
        private System.Windows.Forms.ToolStripMenuItem btn삭제;
        private System.Windows.Forms.ToolStripMenuItem btn저장;
        private System.Windows.Forms.ToolStripMenuItem btn창닫기;
        private System.Windows.Forms.ToolStripMenuItem btn취소;

    }
}