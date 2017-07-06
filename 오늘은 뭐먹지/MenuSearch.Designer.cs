namespace 오늘은_뭐먹지
{
    partial class MenuSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSearch));
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.listView_search = new System.Windows.Forms.ListView();
            this.columnHeader제목 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader링크 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader전번 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader일반주소 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader도로명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btn_connectWeb = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(635, 7);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 39);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(529, 7);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 39);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "추가";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // listView_search
            // 
            this.listView_search.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader제목,
            this.columnHeader링크,
            this.columnHeader전번,
            this.columnHeader일반주소,
            this.columnHeader도로명});
            this.listView_search.FullRowSelect = true;
            this.listView_search.HideSelection = false;
            this.listView_search.Location = new System.Drawing.Point(12, 65);
            this.listView_search.Name = "listView_search";
            this.listView_search.Size = new System.Drawing.Size(723, 404);
            this.listView_search.TabIndex = 12;
            this.listView_search.UseCompatibleStateImageBehavior = false;
            this.listView_search.View = System.Windows.Forms.View.Details;
            this.listView_search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_search_MouseDown);
            // 
            // columnHeader제목
            // 
            this.columnHeader제목.Text = "타이틀";
            this.columnHeader제목.Width = 200;
            // 
            // columnHeader링크
            // 
            this.columnHeader링크.Text = "링크";
            this.columnHeader링크.Width = 50;
            // 
            // columnHeader전번
            // 
            this.columnHeader전번.Text = "전화번호";
            this.columnHeader전번.Width = 130;
            // 
            // columnHeader일반주소
            // 
            this.columnHeader일반주소.Text = "주소";
            this.columnHeader일반주소.Width = 180;
            // 
            // columnHeader도로명
            // 
            this.columnHeader도로명.Text = "도로명주소";
            this.columnHeader도로명.Width = 180;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(41, 25);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(283, 21);
            this.textBox_search.TabIndex = 11;
            // 
            // btn_connectWeb
            // 
            this.btn_connectWeb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_connectWeb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_connectWeb.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_connectWeb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_connectWeb.Location = new System.Drawing.Point(429, 7);
            this.btn_connectWeb.Name = "btn_connectWeb";
            this.btn_connectWeb.Size = new System.Drawing.Size(94, 39);
            this.btn_connectWeb.TabIndex = 9;
            this.btn_connectWeb.Text = "자세히 보기";
            this.btn_connectWeb.UseVisualStyleBackColor = false;
            this.btn_connectWeb.Click += new System.EventHandler(this.btn_connectWeb_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(338, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // MenuSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(749, 480);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.listView_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.btn_connectWeb);
            this.Controls.Add(this.btn_search);
            this.Name = "MenuSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.ListView listView_search;
        private System.Windows.Forms.ColumnHeader columnHeader제목;
        private System.Windows.Forms.ColumnHeader columnHeader링크;
        private System.Windows.Forms.ColumnHeader columnHeader전번;
        private System.Windows.Forms.ColumnHeader columnHeader일반주소;
        private System.Windows.Forms.ColumnHeader columnHeader도로명;
        public System.Windows.Forms.TextBox textBox_search;
        public System.Windows.Forms.Button btn_connectWeb;
        private System.Windows.Forms.Button btn_search;
    }
}