namespace 오늘은_뭐먹지
{
    partial class InsertForm
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertForm));
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.button_dlgInsertCANCEL = new System.Windows.Forms.Button();
            this.button_dlgInsertOK = new System.Windows.Forms.Button();
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.textBox_store = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_menu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_category
            // 
            this.comboBox_category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Items.AddRange(new object[] {
            "양식",
            "중식",
            "한식"});
            this.comboBox_category.Location = new System.Drawing.Point(269, 180);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(165, 20);
            this.comboBox_category.TabIndex = 19;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_search.Location = new System.Drawing.Point(205, 394);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(243, 28);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "검색 API(네이버 DB 활용)";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // button_dlgInsertCANCEL
            // 
            this.button_dlgInsertCANCEL.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_dlgInsertCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_dlgInsertCANCEL.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_dlgInsertCANCEL.Location = new System.Drawing.Point(353, 345);
            this.button_dlgInsertCANCEL.Name = "button_dlgInsertCANCEL";
            this.button_dlgInsertCANCEL.Size = new System.Drawing.Size(95, 28);
            this.button_dlgInsertCANCEL.TabIndex = 16;
            this.button_dlgInsertCANCEL.Text = "취소";
            this.button_dlgInsertCANCEL.UseVisualStyleBackColor = false;
            this.button_dlgInsertCANCEL.Click += new System.EventHandler(this.button_dlgInsertCANCEL_Click);
            // 
            // button_dlgInsertOK
            // 
            this.button_dlgInsertOK.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_dlgInsertOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_dlgInsertOK.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_dlgInsertOK.Location = new System.Drawing.Point(205, 345);
            this.button_dlgInsertOK.Name = "button_dlgInsertOK";
            this.button_dlgInsertOK.Size = new System.Drawing.Size(95, 28);
            this.button_dlgInsertOK.TabIndex = 17;
            this.button_dlgInsertOK.Text = "추가";
            this.button_dlgInsertOK.UseVisualStyleBackColor = false;
            this.button_dlgInsertOK.Click += new System.EventHandler(this.button_dlgInsertOK_Click);
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new System.Drawing.Point(269, 301);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(165, 21);
            this.textBox_add.TabIndex = 11;
            // 
            // textBox_store
            // 
            this.textBox_store.Location = new System.Drawing.Point(269, 265);
            this.textBox_store.Name = "textBox_store";
            this.textBox_store.Size = new System.Drawing.Size(165, 21);
            this.textBox_store.TabIndex = 12;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(269, 224);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(165, 21);
            this.textBox_phone.TabIndex = 13;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(269, 141);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(165, 21);
            this.textBox_price.TabIndex = 14;
            // 
            // textBox_menu
            // 
            this.textBox_menu.Location = new System.Drawing.Point(269, 102);
            this.textBox_menu.Name = "textBox_menu";
            this.textBox_menu.Size = new System.Drawing.Size(165, 21);
            this.textBox_menu.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(229, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(216, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "식당명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(203, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "전화번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(228, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "분류";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(228, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "가격";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(228, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "메뉴";
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.button_dlgInsertCANCEL);
            this.Controls.Add(this.button_dlgInsertOK);
            this.Controls.Add(this.textBox_add);
            this.Controls.Add(this.textBox_store);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_menu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "InsertForm";
            this.Size = new System.Drawing.Size(649, 525);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button button_dlgInsertCANCEL;
        private System.Windows.Forms.Button button_dlgInsertOK;
        public System.Windows.Forms.TextBox textBox_add;
        public System.Windows.Forms.TextBox textBox_store;
        public System.Windows.Forms.TextBox textBox_phone;
        public System.Windows.Forms.TextBox textBox_price;
        public System.Windows.Forms.TextBox textBox_menu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}
