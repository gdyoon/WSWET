namespace 오늘은_뭐먹지
{
    partial class EvalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvalForm));
            this.button1 = new System.Windows.Forms.Button();
            this.listView_eval = new System.Windows.Forms.ListView();
            this.columnHeader넘버 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column메뉴 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column전번 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column식당 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_evalOK = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(93, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "불러오기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView_eval
            // 
            this.listView_eval.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_eval.CausesValidation = false;
            this.listView_eval.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader넘버,
            this.column메뉴,
            this.column전번,
            this.column식당});
            this.listView_eval.FullRowSelect = true;
            this.listView_eval.HideSelection = false;
            this.listView_eval.Location = new System.Drawing.Point(246, 15);
            this.listView_eval.Name = "listView_eval";
            this.listView_eval.Size = new System.Drawing.Size(310, 494);
            this.listView_eval.TabIndex = 14;
            this.listView_eval.UseCompatibleStateImageBehavior = false;
            this.listView_eval.View = System.Windows.Forms.View.Details;
            this.listView_eval.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_eval_MouseDown);
            // 
            // columnHeader넘버
            // 
            this.columnHeader넘버.Text = "No";
            this.columnHeader넘버.Width = 0;
            // 
            // column메뉴
            // 
            this.column메뉴.Text = "메뉴";
            this.column메뉴.Width = 90;
            // 
            // column전번
            // 
            this.column전번.Text = "전화번호";
            this.column전번.Width = 120;
            // 
            // column식당
            // 
            this.column식당.Text = "식당명";
            this.column식당.Width = 90;
            // 
            // btn_evalOK
            // 
            this.btn_evalOK.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_evalOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_evalOK.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_evalOK.Location = new System.Drawing.Point(93, 201);
            this.btn_evalOK.Name = "btn_evalOK";
            this.btn_evalOK.Size = new System.Drawing.Size(143, 45);
            this.btn_evalOK.TabIndex = 13;
            this.btn_evalOK.Text = "평가하기";
            this.btn_evalOK.UseVisualStyleBackColor = false;
            this.btn_evalOK.Click += new System.EventHandler(this.btn_evalOK_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.Font = new System.Drawing.Font("휴먼모음T", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton5.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton5.Location = new System.Drawing.Point(103, 157);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(54, 21);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "1 점";
            this.radioButton5.UseVisualStyleBackColor = false;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Font = new System.Drawing.Font("휴먼모음T", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton4.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton4.Location = new System.Drawing.Point(103, 135);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(54, 21);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "2 점";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("휴먼모음T", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton3.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton3.Location = new System.Drawing.Point(103, 113);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 21);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3 점";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("휴먼모음T", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(103, 91);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 21);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "4 점";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("휴먼모음T", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton1.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(103, 69);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 21);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5 점";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(92, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "평점을 매겨주세요";
            // 
            // EvalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView_eval);
            this.Controls.Add(this.btn_evalOK);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "EvalForm";
            this.Size = new System.Drawing.Size(649, 525);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView listView_eval;
        private System.Windows.Forms.ColumnHeader columnHeader넘버;
        public System.Windows.Forms.ColumnHeader column메뉴;
        public System.Windows.Forms.ColumnHeader column전번;
        public System.Windows.Forms.ColumnHeader column식당;
        private System.Windows.Forms.Button btn_evalOK;
        public System.Windows.Forms.RadioButton radioButton5;
        public System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}
