namespace HISYSENG_Logitech
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.g_Menu = new System.Windows.Forms.MenuStrip();
            this.기초정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn사용자관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn사용자권한 = new System.Windows.Forms.ToolStripMenuItem();
            this.거래처ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn거래처관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.제품ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn제품관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn제품단가 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.차량관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn지게차 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn배송차량 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn회사관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.매입ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.발주등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn발주등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn발주관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.입고관리ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn입고의뢰 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn입고의뢰관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.매입마감ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn매입마감처리 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn매입마감조회 = new System.Windows.Forms.ToolStripMenuItem();
            this.영업ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn수주관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn출하의뢰 = new System.Windows.Forms.ToolStripMenuItem();
            this.매출마감ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn매출마감처리 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn매출마감조회 = new System.Windows.Forms.ToolStripMenuItem();
            this.자재ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn재고현황 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn입고관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn출하관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.매입마감ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn자재마감처리 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn자재마감조회 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn백홀링 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn백홀링관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn백홀링정산 = new System.Windows.Forms.ToolStripMenuItem();
            this.밀크런ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn밀크런관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn밀크런정산 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.g_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // g_Menu
            // 
            this.g_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기초정보ToolStripMenuItem,
            this.매입ToolStripMenuItem,
            this.영업ToolStripMenuItem,
            this.자재ToolStripMenuItem,
            this.btn백홀링,
            this.밀크런ToolStripMenuItem});
            this.g_Menu.Location = new System.Drawing.Point(0, 0);
            this.g_Menu.Name = "g_Menu";
            this.g_Menu.Size = new System.Drawing.Size(1122, 24);
            this.g_Menu.TabIndex = 5;
            this.g_Menu.Text = "menuStrip1";
            // 
            // 기초정보ToolStripMenuItem
            // 
            this.기초정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용자ToolStripMenuItem,
            this.거래처ToolStripMenuItem,
            this.제품ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.차량관리ToolStripMenuItem,
            this.btn회사관리});
            this.기초정보ToolStripMenuItem.Name = "기초정보ToolStripMenuItem";
            this.기초정보ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.기초정보ToolStripMenuItem.Text = "기초정보";
            // 
            // 사용자ToolStripMenuItem
            // 
            this.사용자ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn사용자관리,
            this.btn사용자권한});
            this.사용자ToolStripMenuItem.Name = "사용자ToolStripMenuItem";
            this.사용자ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.사용자ToolStripMenuItem.Text = "사용자";
            // 
            // btn사용자관리
            // 
            this.btn사용자관리.Name = "btn사용자관리";
            this.btn사용자관리.Size = new System.Drawing.Size(152, 22);
            this.btn사용자관리.Text = "사용자 관리";
            this.btn사용자관리.Click += new System.EventHandler(this.btn사용자관리_Click);
            // 
            // btn사용자권한
            // 
            this.btn사용자권한.Name = "btn사용자권한";
            this.btn사용자권한.Size = new System.Drawing.Size(152, 22);
            this.btn사용자권한.Text = "사용자 권한";
            // 
            // 거래처ToolStripMenuItem
            // 
            this.거래처ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn거래처관리});
            this.거래처ToolStripMenuItem.Name = "거래처ToolStripMenuItem";
            this.거래처ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.거래처ToolStripMenuItem.Text = "거래처";
            // 
            // btn거래처관리
            // 
            this.btn거래처관리.Name = "btn거래처관리";
            this.btn거래처관리.Size = new System.Drawing.Size(152, 22);
            this.btn거래처관리.Text = "거래처 관리";
            // 
            // 제품ToolStripMenuItem
            // 
            this.제품ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn제품관리,
            this.btn제품단가});
            this.제품ToolStripMenuItem.Name = "제품ToolStripMenuItem";
            this.제품ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.제품ToolStripMenuItem.Text = "제품";
            // 
            // btn제품관리
            // 
            this.btn제품관리.Name = "btn제품관리";
            this.btn제품관리.Size = new System.Drawing.Size(122, 22);
            this.btn제품관리.Text = "제품관리";
            // 
            // btn제품단가
            // 
            this.btn제품단가.Name = "btn제품단가";
            this.btn제품단가.Size = new System.Drawing.Size(122, 22);
            this.btn제품단가.Text = "제품단가";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // 차량관리ToolStripMenuItem
            // 
            this.차량관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn지게차,
            this.btn배송차량});
            this.차량관리ToolStripMenuItem.Name = "차량관리ToolStripMenuItem";
            this.차량관리ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.차량관리ToolStripMenuItem.Text = "기구/차량";
            // 
            // btn지게차
            // 
            this.btn지게차.Name = "btn지게차";
            this.btn지게차.Size = new System.Drawing.Size(122, 22);
            this.btn지게차.Text = "지게차";
            // 
            // btn배송차량
            // 
            this.btn배송차량.Name = "btn배송차량";
            this.btn배송차량.Size = new System.Drawing.Size(122, 22);
            this.btn배송차량.Text = "배송차량";
            // 
            // btn회사관리
            // 
            this.btn회사관리.Name = "btn회사관리";
            this.btn회사관리.Size = new System.Drawing.Size(152, 22);
            this.btn회사관리.Text = "회사관리";
            this.btn회사관리.Click += new System.EventHandler(this.btn회사관리_Click);
            // 
            // 매입ToolStripMenuItem
            // 
            this.매입ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.발주등록ToolStripMenuItem,
            this.입고관리ToolStripMenuItem1,
            this.매입마감ToolStripMenuItem1});
            this.매입ToolStripMenuItem.Name = "매입ToolStripMenuItem";
            this.매입ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.매입ToolStripMenuItem.Text = "매입";
            // 
            // 발주등록ToolStripMenuItem
            // 
            this.발주등록ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn발주등록,
            this.btn발주관리});
            this.발주등록ToolStripMenuItem.Name = "발주등록ToolStripMenuItem";
            this.발주등록ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.발주등록ToolStripMenuItem.Text = "발주관리";
            // 
            // btn발주등록
            // 
            this.btn발주등록.Name = "btn발주등록";
            this.btn발주등록.Size = new System.Drawing.Size(122, 22);
            this.btn발주등록.Text = "발주등록";
            // 
            // btn발주관리
            // 
            this.btn발주관리.Name = "btn발주관리";
            this.btn발주관리.Size = new System.Drawing.Size(122, 22);
            this.btn발주관리.Text = "발주관리";
            // 
            // 입고관리ToolStripMenuItem1
            // 
            this.입고관리ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn입고의뢰,
            this.btn입고의뢰관리});
            this.입고관리ToolStripMenuItem1.Name = "입고관리ToolStripMenuItem1";
            this.입고관리ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.입고관리ToolStripMenuItem1.Text = "입고관리";
            // 
            // btn입고의뢰
            // 
            this.btn입고의뢰.Name = "btn입고의뢰";
            this.btn입고의뢰.Size = new System.Drawing.Size(146, 22);
            this.btn입고의뢰.Text = "입고의뢰";
            // 
            // btn입고의뢰관리
            // 
            this.btn입고의뢰관리.Name = "btn입고의뢰관리";
            this.btn입고의뢰관리.Size = new System.Drawing.Size(146, 22);
            this.btn입고의뢰관리.Text = "입고의뢰관리";
            // 
            // 매입마감ToolStripMenuItem1
            // 
            this.매입마감ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn매입마감처리,
            this.btn매입마감조회});
            this.매입마감ToolStripMenuItem1.Name = "매입마감ToolStripMenuItem1";
            this.매입마감ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.매입마감ToolStripMenuItem1.Text = "매입마감";
            // 
            // btn매입마감처리
            // 
            this.btn매입마감처리.Name = "btn매입마감처리";
            this.btn매입마감처리.Size = new System.Drawing.Size(150, 22);
            this.btn매입마감처리.Text = "매입마감 처리";
            // 
            // btn매입마감조회
            // 
            this.btn매입마감조회.Name = "btn매입마감조회";
            this.btn매입마감조회.Size = new System.Drawing.Size(150, 22);
            this.btn매입마감조회.Text = "매입마감 조회";
            // 
            // 영업ToolStripMenuItem
            // 
            this.영업ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.매출등록ToolStripMenuItem,
            this.매출마감ToolStripMenuItem});
            this.영업ToolStripMenuItem.Name = "영업ToolStripMenuItem";
            this.영업ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.영업ToolStripMenuItem.Text = "매출";
            // 
            // 매출등록ToolStripMenuItem
            // 
            this.매출등록ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn수주관리,
            this.btn출하의뢰});
            this.매출등록ToolStripMenuItem.Name = "매출등록ToolStripMenuItem";
            this.매출등록ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.매출등록ToolStripMenuItem.Text = "매출관리";
            // 
            // btn수주관리
            // 
            this.btn수주관리.Name = "btn수주관리";
            this.btn수주관리.Size = new System.Drawing.Size(122, 22);
            this.btn수주관리.Text = "수주관리";
            // 
            // btn출하의뢰
            // 
            this.btn출하의뢰.Name = "btn출하의뢰";
            this.btn출하의뢰.Size = new System.Drawing.Size(122, 22);
            this.btn출하의뢰.Text = "출하의뢰";
            // 
            // 매출마감ToolStripMenuItem
            // 
            this.매출마감ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn매출마감처리,
            this.btn매출마감조회});
            this.매출마감ToolStripMenuItem.Name = "매출마감ToolStripMenuItem";
            this.매출마감ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.매출마감ToolStripMenuItem.Text = "매출마감";
            // 
            // btn매출마감처리
            // 
            this.btn매출마감처리.Name = "btn매출마감처리";
            this.btn매출마감처리.Size = new System.Drawing.Size(150, 22);
            this.btn매출마감처리.Text = "매출마감 처리";
            // 
            // btn매출마감조회
            // 
            this.btn매출마감조회.Name = "btn매출마감조회";
            this.btn매출마감조회.Size = new System.Drawing.Size(150, 22);
            this.btn매출마감조회.Text = "매출마감 조회";
            // 
            // 자재ToolStripMenuItem
            // 
            this.자재ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn재고현황,
            this.btn입고관리,
            this.btn출하관리,
            this.매입마감ToolStripMenuItem});
            this.자재ToolStripMenuItem.Name = "자재ToolStripMenuItem";
            this.자재ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.자재ToolStripMenuItem.Text = "자재";
            // 
            // btn재고현황
            // 
            this.btn재고현황.Name = "btn재고현황";
            this.btn재고현황.Size = new System.Drawing.Size(122, 22);
            this.btn재고현황.Text = "재고현황";
            // 
            // btn입고관리
            // 
            this.btn입고관리.Name = "btn입고관리";
            this.btn입고관리.Size = new System.Drawing.Size(122, 22);
            this.btn입고관리.Text = "입고관리";
            // 
            // btn출하관리
            // 
            this.btn출하관리.Name = "btn출하관리";
            this.btn출하관리.Size = new System.Drawing.Size(122, 22);
            this.btn출하관리.Text = "출하관리";
            // 
            // 매입마감ToolStripMenuItem
            // 
            this.매입마감ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn자재마감처리,
            this.btn자재마감조회});
            this.매입마감ToolStripMenuItem.Name = "매입마감ToolStripMenuItem";
            this.매입마감ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.매입마감ToolStripMenuItem.Text = "자재마감";
            // 
            // btn자재마감처리
            // 
            this.btn자재마감처리.Name = "btn자재마감처리";
            this.btn자재마감처리.Size = new System.Drawing.Size(150, 22);
            this.btn자재마감처리.Text = "자재마감 처리";
            // 
            // btn자재마감조회
            // 
            this.btn자재마감조회.Name = "btn자재마감조회";
            this.btn자재마감조회.Size = new System.Drawing.Size(150, 22);
            this.btn자재마감조회.Text = "자재마감 조회";
            // 
            // btn백홀링
            // 
            this.btn백홀링.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn백홀링관리,
            this.btn백홀링정산});
            this.btn백홀링.Name = "btn백홀링";
            this.btn백홀링.Size = new System.Drawing.Size(55, 20);
            this.btn백홀링.Text = "백홀링";
            // 
            // btn백홀링관리
            // 
            this.btn백홀링관리.Name = "btn백홀링관리";
            this.btn백홀링관리.Size = new System.Drawing.Size(138, 22);
            this.btn백홀링관리.Text = "백홀링 관리";
            // 
            // btn백홀링정산
            // 
            this.btn백홀링정산.Name = "btn백홀링정산";
            this.btn백홀링정산.Size = new System.Drawing.Size(138, 22);
            this.btn백홀링정산.Text = "백홀링 정산";
            // 
            // 밀크런ToolStripMenuItem
            // 
            this.밀크런ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn밀크런관리,
            this.btn밀크런정산});
            this.밀크런ToolStripMenuItem.Name = "밀크런ToolStripMenuItem";
            this.밀크런ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.밀크런ToolStripMenuItem.Text = "밀크런";
            this.밀크런ToolStripMenuItem.Visible = false;
            // 
            // btn밀크런관리
            // 
            this.btn밀크런관리.Name = "btn밀크런관리";
            this.btn밀크런관리.Size = new System.Drawing.Size(138, 22);
            this.btn밀크런관리.Text = "밀크런 관리";
            // 
            // btn밀크런정산
            // 
            this.btn밀크런정산.Name = "btn밀크런정산";
            this.btn밀크런정산.Size = new System.Drawing.Size(138, 22);
            this.btn밀크런정산.Text = "밀크런 정산";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(973, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 7;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 623);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.g_Menu);
            this.Font = new System.Drawing.Font("Verdana", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.g_Menu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HISYSENG Logitech Ver 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.g_Menu.ResumeLayout(false);
            this.g_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip g_Menu;
        private System.Windows.Forms.ToolStripMenuItem 기초정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn사용자관리;
        private System.Windows.Forms.ToolStripMenuItem btn사용자권한;
        private System.Windows.Forms.ToolStripMenuItem 거래처ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn거래처관리;
        private System.Windows.Forms.ToolStripMenuItem 제품ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn제품관리;
        private System.Windows.Forms.ToolStripMenuItem btn제품단가;
        private System.Windows.Forms.ToolStripMenuItem 매입ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 영업ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출마감ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자재ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn재고현황;
        private System.Windows.Forms.ToolStripMenuItem btn입고관리;
        private System.Windows.Forms.ToolStripMenuItem btn출하관리;
        private System.Windows.Forms.ToolStripMenuItem 매입마감ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 발주등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn발주등록;
        private System.Windows.Forms.ToolStripMenuItem 입고관리ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btn입고의뢰;
        private System.Windows.Forms.ToolStripMenuItem 매입마감ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btn매입마감처리;
        private System.Windows.Forms.ToolStripMenuItem btn매입마감조회;
        private System.Windows.Forms.ToolStripMenuItem btn수주관리;
        private System.Windows.Forms.ToolStripMenuItem btn출하의뢰;
        private System.Windows.Forms.ToolStripMenuItem btn매출마감처리;
        private System.Windows.Forms.ToolStripMenuItem btn매출마감조회;
        private System.Windows.Forms.ToolStripMenuItem btn자재마감처리;
        private System.Windows.Forms.ToolStripMenuItem btn자재마감조회;
        private System.Windows.Forms.ToolStripMenuItem btn백홀링;
        private System.Windows.Forms.ToolStripMenuItem btn백홀링관리;
        private System.Windows.Forms.ToolStripMenuItem btn백홀링정산;
        private System.Windows.Forms.ToolStripMenuItem 밀크런ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn밀크런관리;
        private System.Windows.Forms.ToolStripMenuItem btn밀크런정산;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 차량관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn지게차;
        private System.Windows.Forms.ToolStripMenuItem btn배송차량;
        private System.Windows.Forms.ToolStripMenuItem btn발주관리;
        private System.Windows.Forms.ToolStripMenuItem btn입고의뢰관리;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem btn회사관리;
    }
}

