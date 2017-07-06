namespace 오늘은_뭐먹지
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dB해제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴추가ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴평가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.오늘의메뉴추천ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주일식단추천ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.식당위치보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기타EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.개발자정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dB연결ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_main = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.메뉴MToolStripMenuItem,
            this.기타EToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dB연결ToolStripMenuItem,
            this.dB해제ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // dB해제ToolStripMenuItem
            // 
            this.dB해제ToolStripMenuItem.Name = "dB해제ToolStripMenuItem";
            this.dB해제ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dB해제ToolStripMenuItem.Text = "DB 해제";
            this.dB해제ToolStripMenuItem.Click += new System.EventHandler(this.dB해제ToolStripMenuItem_Click);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 메뉴MToolStripMenuItem
            // 
            this.메뉴MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴추가ToolStripMenuItem1,
            this.메뉴평가ToolStripMenuItem,
            this.오늘의메뉴추천ToolStripMenuItem,
            this.주일식단추천ToolStripMenuItem,
            this.식당위치보기ToolStripMenuItem});
            this.메뉴MToolStripMenuItem.Name = "메뉴MToolStripMenuItem";
            this.메뉴MToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.메뉴MToolStripMenuItem.Text = "메뉴(&M)";
            // 
            // 메뉴추가ToolStripMenuItem1
            // 
            this.메뉴추가ToolStripMenuItem1.Name = "메뉴추가ToolStripMenuItem1";
            this.메뉴추가ToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.메뉴추가ToolStripMenuItem1.Text = "메뉴 추가";
            this.메뉴추가ToolStripMenuItem1.Click += new System.EventHandler(this.메뉴추가ToolStripMenuItem1_Click);
            // 
            // 메뉴평가ToolStripMenuItem
            // 
            this.메뉴평가ToolStripMenuItem.Name = "메뉴평가ToolStripMenuItem";
            this.메뉴평가ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.메뉴평가ToolStripMenuItem.Text = "메뉴 평가";
            this.메뉴평가ToolStripMenuItem.Click += new System.EventHandler(this.메뉴평가ToolStripMenuItem_Click);
            // 
            // 오늘의메뉴추천ToolStripMenuItem
            // 
            this.오늘의메뉴추천ToolStripMenuItem.Name = "오늘의메뉴추천ToolStripMenuItem";
            this.오늘의메뉴추천ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.오늘의메뉴추천ToolStripMenuItem.Text = "오늘의 메뉴 추천";
            this.오늘의메뉴추천ToolStripMenuItem.Click += new System.EventHandler(this.오늘의메뉴추천ToolStripMenuItem_Click);
            // 
            // 주일식단추천ToolStripMenuItem
            // 
            this.주일식단추천ToolStripMenuItem.Name = "주일식단추천ToolStripMenuItem";
            this.주일식단추천ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.주일식단추천ToolStripMenuItem.Text = "1주일 식단 추천";
            this.주일식단추천ToolStripMenuItem.Click += new System.EventHandler(this.주일식단추천ToolStripMenuItem_Click);
            // 
            // 식당위치보기ToolStripMenuItem
            // 
            this.식당위치보기ToolStripMenuItem.Name = "식당위치보기ToolStripMenuItem";
            this.식당위치보기ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.식당위치보기ToolStripMenuItem.Text = "식당 위치보기";
            this.식당위치보기ToolStripMenuItem.Click += new System.EventHandler(this.식당위치보기ToolStripMenuItem_Click);
            // 
            // 기타EToolStripMenuItem
            // 
            this.기타EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.개발자정보ToolStripMenuItem});
            this.기타EToolStripMenuItem.Name = "기타EToolStripMenuItem";
            this.기타EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.기타EToolStripMenuItem.Text = "기타(&E)";
            // 
            // 개발자정보ToolStripMenuItem
            // 
            this.개발자정보ToolStripMenuItem.Name = "개발자정보ToolStripMenuItem";
            this.개발자정보ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.개발자정보ToolStripMenuItem.Text = "개발자 정보";
            this.개발자정보ToolStripMenuItem.Click += new System.EventHandler(this.개발자정보ToolStripMenuItem_Click);
            // 
            // dB연결ToolStripMenuItem
            // 
            this.dB연결ToolStripMenuItem.Name = "dB연결ToolStripMenuItem";
            this.dB연결ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dB연결ToolStripMenuItem.Text = "DB 연결";
            this.dB연결ToolStripMenuItem.Click += new System.EventHandler(this.dB연결ToolStripMenuItem_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_main.BackgroundImage")));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Location = new System.Drawing.Point(242, 38);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(649, 525);
            this.panel_main.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 139);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(903, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "오늘은 뭐먹지";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dB해제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴추가ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴평가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 오늘의메뉴추천ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주일식단추천ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 식당위치보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기타EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 개발자정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dB연결ToolStripMenuItem;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

