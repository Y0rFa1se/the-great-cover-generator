namespace the_great_cover_generator
{
	partial class the_great_cover_generator
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
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(the_great_cover_generator));
			this.adsbanner = new AdsJumboWinForm.BannerAds();
			this.picture_dir_listbox = new System.Windows.Forms.ListBox();
			this.run_button = new System.Windows.Forms.Button();
			this.resize_radiobutton = new System.Windows.Forms.RadioButton();
			this.cut_radiobutton = new System.Windows.Forms.RadioButton();
			this.img_handling_label = new System.Windows.Forms.Label();
			this.subject_combobox = new System.Windows.Forms.ComboBox();
			this.subject_label = new System.Windows.Forms.Label();
			this.description_label = new System.Windows.Forms.Label();
			this.output_dir_button = new System.Windows.Forms.Button();
			this.picture_picbox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picture_picbox)).BeginInit();
			this.SuspendLayout();
			// 
			// adsbanner
			// 
			this.adsbanner.ApplicationId = null;
			this.adsbanner.BackColor = System.Drawing.Color.White;
			this.adsbanner.HeightAd = 0;
			this.adsbanner.Location = new System.Drawing.Point(111, 456);
			this.adsbanner.Margin = new System.Windows.Forms.Padding(4);
			this.adsbanner.Name = "adsbanner";
			this.adsbanner.Size = new System.Drawing.Size(728, 90);
			this.adsbanner.TabIndex = 1;
			this.adsbanner.WidthAd = 0;
			// 
			// picture_dir_listbox
			// 
			this.picture_dir_listbox.FormattingEnabled = true;
			this.picture_dir_listbox.ItemHeight = 14;
			this.picture_dir_listbox.Items.AddRange(new object[] {
            "사진을 선택해주세요 (여러장 선택 가능)"});
			this.picture_dir_listbox.Location = new System.Drawing.Point(376, 35);
			this.picture_dir_listbox.Name = "picture_dir_listbox";
			this.picture_dir_listbox.Size = new System.Drawing.Size(539, 200);
			this.picture_dir_listbox.TabIndex = 2;
			this.picture_dir_listbox.SelectedIndexChanged += new System.EventHandler(this.picture_dir_listbox_SelectedIndexChanged);
			// 
			// run_button
			// 
			this.run_button.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.run_button.Location = new System.Drawing.Point(745, 383);
			this.run_button.Name = "run_button";
			this.run_button.Size = new System.Drawing.Size(170, 52);
			this.run_button.TabIndex = 3;
			this.run_button.Text = "실행";
			this.run_button.UseVisualStyleBackColor = true;
			this.run_button.Click += new System.EventHandler(this.run_button_Click);
			// 
			// resize_radiobutton
			// 
			this.resize_radiobutton.AutoSize = true;
			this.resize_radiobutton.Location = new System.Drawing.Point(388, 325);
			this.resize_radiobutton.Name = "resize_radiobutton";
			this.resize_radiobutton.Size = new System.Drawing.Size(163, 18);
			this.resize_radiobutton.TabIndex = 4;
			this.resize_radiobutton.Text = "늘이기 (그닥 추천하지 않음)";
			this.resize_radiobutton.UseVisualStyleBackColor = true;
			// 
			// cut_radiobutton
			// 
			this.cut_radiobutton.AutoSize = true;
			this.cut_radiobutton.Checked = true;
			this.cut_radiobutton.Location = new System.Drawing.Point(388, 301);
			this.cut_radiobutton.Name = "cut_radiobutton";
			this.cut_radiobutton.Size = new System.Drawing.Size(102, 18);
			this.cut_radiobutton.TabIndex = 5;
			this.cut_radiobutton.TabStop = true;
			this.cut_radiobutton.Text = "자르기 (권장됨)";
			this.cut_radiobutton.UseVisualStyleBackColor = true;
			// 
			// img_handling_label
			// 
			this.img_handling_label.AutoSize = true;
			this.img_handling_label.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.img_handling_label.Location = new System.Drawing.Point(385, 262);
			this.img_handling_label.Name = "img_handling_label";
			this.img_handling_label.Size = new System.Drawing.Size(123, 17);
			this.img_handling_label.TabIndex = 6;
			this.img_handling_label.Text = "이미지 처리 방식";
			// 
			// subject_combobox
			// 
			this.subject_combobox.FormattingEnabled = true;
			this.subject_combobox.Items.AddRange(new object[] {
            "독서",
            "문학",
            "언어와 매체",
            "화법과 작문",
            "영어",
            "영어듣기",
            "영어 독해 연습",
            "수학1",
            "수학2",
            "미적분",
            "기하",
            "확률과 통계",
            "한국사",
            "물리학1",
            "물리학2",
            "화학1",
            "화학2",
            "생명과학1",
            "생명과학2",
            "지구과학1",
            "지구과학2",
            "생활과 윤리",
            "윤리와 사상",
            "한국지리",
            "세계지리",
            "동아시아사",
            "세계사",
            "정치와 법",
            "경제",
            "사회 문화",
            "독일어",
            "프랑스어",
            "스페인어",
            "중국어",
            "일본어",
            "러시아어",
            "아랍어",
            "베트남어",
            "한문"});
			this.subject_combobox.Location = new System.Drawing.Point(581, 297);
			this.subject_combobox.Name = "subject_combobox";
			this.subject_combobox.Size = new System.Drawing.Size(121, 22);
			this.subject_combobox.TabIndex = 7;
			this.subject_combobox.SelectedIndexChanged += new System.EventHandler(this.subject_combobox_SelectedIndexChanged);
			// 
			// subject_label
			// 
			this.subject_label.AutoSize = true;
			this.subject_label.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.subject_label.Location = new System.Drawing.Point(578, 262);
			this.subject_label.Name = "subject_label";
			this.subject_label.Size = new System.Drawing.Size(73, 17);
			this.subject_label.TabIndex = 8;
			this.subject_label.Text = "과목 선택";
			// 
			// description_label
			// 
			this.description_label.AutoSize = true;
			this.description_label.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.description_label.Location = new System.Drawing.Point(742, 262);
			this.description_label.Name = "description_label";
			this.description_label.Size = new System.Drawing.Size(173, 84);
			this.description_label.TabIndex = 9;
			this.description_label.Text = "※이미지 처리 방식을 바꾼 후에는\r\n이미지를 다시 불러와 주세요\r\n\r\n※이미지가 변형되는게 꼬우시면\r\n이미지 사이즈를\r\n800x1009로 준비해 " +
    "주세요★";
			// 
			// output_dir_button
			// 
			this.output_dir_button.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.output_dir_button.Location = new System.Drawing.Point(388, 383);
			this.output_dir_button.Name = "output_dir_button";
			this.output_dir_button.Size = new System.Drawing.Size(314, 52);
			this.output_dir_button.TabIndex = 10;
			this.output_dir_button.Text = "출력 경로";
			this.output_dir_button.UseVisualStyleBackColor = true;
			this.output_dir_button.Click += new System.EventHandler(this.output_dir_button_Click);
			// 
			// picture_picbox
			// 
			this.picture_picbox.Image = global::the_great_cover_generator.Properties.Resources.사진_넣어주세요;
			this.picture_picbox.Location = new System.Drawing.Point(31, 35);
			this.picture_picbox.Name = "picture_picbox";
			this.picture_picbox.Size = new System.Drawing.Size(320, 400);
			this.picture_picbox.TabIndex = 0;
			this.picture_picbox.TabStop = false;
			this.picture_picbox.Click += new System.EventHandler(this.picture_picbox_Click);
			// 
			// the_great_cover_generator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 568);
			this.Controls.Add(this.output_dir_button);
			this.Controls.Add(this.description_label);
			this.Controls.Add(this.subject_label);
			this.Controls.Add(this.subject_combobox);
			this.Controls.Add(this.img_handling_label);
			this.Controls.Add(this.cut_radiobutton);
			this.Controls.Add(this.resize_radiobutton);
			this.Controls.Add(this.run_button);
			this.Controls.Add(this.picture_dir_listbox);
			this.Controls.Add(this.adsbanner);
			this.Controls.Add(this.picture_picbox);
			this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "the_great_cover_generator";
			this.Text = "성능좋은 표지 제작기";
			((System.ComponentModel.ISupportInitialize)(this.picture_picbox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picture_picbox;
		private AdsJumboWinForm.BannerAds adsbanner;
		private System.Windows.Forms.ListBox picture_dir_listbox;
		private System.Windows.Forms.Button run_button;
		private System.Windows.Forms.RadioButton resize_radiobutton;
		private System.Windows.Forms.RadioButton cut_radiobutton;
		private System.Windows.Forms.Label img_handling_label;
		private System.Windows.Forms.Label subject_label;
		private System.Windows.Forms.ComboBox subject_combobox;
		private System.Windows.Forms.Label description_label;
		private System.Windows.Forms.Button output_dir_button;
	}
}

