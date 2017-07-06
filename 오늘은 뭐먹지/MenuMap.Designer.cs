namespace 오늘은_뭐먹지
{
    partial class MenuMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMap));
            this.cb_satelite = new System.Windows.Forms.CheckBox();
            this.btn_zoomOut = new System.Windows.Forms.Button();
            this.btn_zoomIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_updatemap = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.listView_map = new System.Windows.Forms.ListView();
            this.columnHeader넘버 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column메뉴 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column전번 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column식당 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader평점 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnX좌표 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnY좌표 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cb_satelite
            // 
            this.cb_satelite.AutoSize = true;
            this.cb_satelite.BackColor = System.Drawing.Color.Transparent;
            this.cb_satelite.Font = new System.Drawing.Font("휴먼모음T", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_satelite.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_satelite.Location = new System.Drawing.Point(830, 30);
            this.cb_satelite.Name = "cb_satelite";
            this.cb_satelite.Size = new System.Drawing.Size(75, 21);
            this.cb_satelite.TabIndex = 17;
            this.cb_satelite.Text = "위성지도";
            this.cb_satelite.UseVisualStyleBackColor = false;
            this.cb_satelite.CheckedChanged += new System.EventHandler(this.cb_satelite_CheckedChanged);
            // 
            // btn_zoomOut
            // 
            this.btn_zoomOut.BackColor = System.Drawing.Color.DarkGray;
            this.btn_zoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_zoomOut.Font = new System.Drawing.Font("휴먼모음T", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_zoomOut.ForeColor = System.Drawing.Color.Transparent;
            this.btn_zoomOut.Location = new System.Drawing.Point(689, 28);
            this.btn_zoomOut.Name = "btn_zoomOut";
            this.btn_zoomOut.Size = new System.Drawing.Size(75, 23);
            this.btn_zoomOut.TabIndex = 15;
            this.btn_zoomOut.Text = "축소";
            this.btn_zoomOut.UseVisualStyleBackColor = false;
            this.btn_zoomOut.Click += new System.EventHandler(this.btn_zoomOut_Click);
            // 
            // btn_zoomIn
            // 
            this.btn_zoomIn.BackColor = System.Drawing.Color.DarkGray;
            this.btn_zoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_zoomIn.Font = new System.Drawing.Font("휴먼모음T", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_zoomIn.ForeColor = System.Drawing.Color.Transparent;
            this.btn_zoomIn.Location = new System.Drawing.Point(608, 28);
            this.btn_zoomIn.Name = "btn_zoomIn";
            this.btn_zoomIn.Size = new System.Drawing.Size(75, 23);
            this.btn_zoomIn.TabIndex = 16;
            this.btn_zoomIn.Text = "확대";
            this.btn_zoomIn.UseVisualStyleBackColor = false;
            this.btn_zoomIn.Click += new System.EventHandler(this.btn_zoomIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(618, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "※ 해당 메뉴 클릭시 지도로 연결됩니다";
            // 
            // btn_updatemap
            // 
            this.btn_updatemap.BackColor = System.Drawing.Color.DarkGray;
            this.btn_updatemap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_updatemap.Font = new System.Drawing.Font("휴먼모음T", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_updatemap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_updatemap.Location = new System.Drawing.Point(609, 640);
            this.btn_updatemap.Name = "btn_updatemap";
            this.btn_updatemap.Size = new System.Drawing.Size(289, 24);
            this.btn_updatemap.TabIndex = 13;
            this.btn_updatemap.Text = "갱신하기";
            this.btn_updatemap.UseVisualStyleBackColor = false;
            this.btn_updatemap.Click += new System.EventHandler(this.btn_updatemap_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(8, 9);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(592, 620);
            this.webBrowser1.TabIndex = 12;
            // 
            // listView_map
            // 
            this.listView_map.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_map.CausesValidation = false;
            this.listView_map.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader넘버,
            this.column메뉴,
            this.column전번,
            this.column식당,
            this.columnHeader평점,
            this.columnX좌표,
            this.columnY좌표});
            this.listView_map.FullRowSelect = true;
            this.listView_map.Location = new System.Drawing.Point(608, 57);
            this.listView_map.Name = "listView_map";
            this.listView_map.Size = new System.Drawing.Size(291, 572);
            this.listView_map.TabIndex = 11;
            this.listView_map.UseCompatibleStateImageBehavior = false;
            this.listView_map.View = System.Windows.Forms.View.Details;
            this.listView_map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_map_MouseDown);
            // 
            // columnHeader넘버
            // 
            this.columnHeader넘버.Text = "No";
            this.columnHeader넘버.Width = 0;
            // 
            // column메뉴
            // 
            this.column메뉴.Text = "메뉴";
            this.column메뉴.Width = 68;
            // 
            // column전번
            // 
            this.column전번.Text = "전화번호";
            // 
            // column식당
            // 
            this.column식당.Text = "식당명";
            this.column식당.Width = 114;
            // 
            // columnHeader평점
            // 
            this.columnHeader평점.Text = "평점";
            this.columnHeader평점.Width = 45;
            // 
            // columnX좌표
            // 
            this.columnX좌표.Text = "x좌표";
            this.columnX좌표.Width = 0;
            // 
            // columnY좌표
            // 
            this.columnY좌표.Text = "y좌표";
            this.columnY좌표.Width = 0;
            // 
            // MenuMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 675);
            this.Controls.Add(this.cb_satelite);
            this.Controls.Add(this.btn_zoomOut);
            this.Controls.Add(this.btn_zoomIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_updatemap);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.listView_map);
            this.Name = "MenuMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuMap";
            this.Load += new System.EventHandler(this.MenuMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_satelite;
        private System.Windows.Forms.Button btn_zoomOut;
        private System.Windows.Forms.Button btn_zoomIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_updatemap;
        public System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.ListView listView_map;
        private System.Windows.Forms.ColumnHeader columnHeader넘버;
        public System.Windows.Forms.ColumnHeader column메뉴;
        public System.Windows.Forms.ColumnHeader column전번;
        public System.Windows.Forms.ColumnHeader column식당;
        private System.Windows.Forms.ColumnHeader columnHeader평점;
        private System.Windows.Forms.ColumnHeader columnX좌표;
        private System.Windows.Forms.ColumnHeader columnY좌표;

    }
}