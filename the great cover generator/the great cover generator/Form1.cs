using OpenCvSharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace the_great_cover_generator
{
	public partial class the_great_cover_generator : Form
	{
		string subject;
		string output_dir;

		int pic_dir_len;


		public the_great_cover_generator()
		{
			InitializeComponent();
			adsbanner.ShowAd(728, 90, "0ejeechs2huk");
			subject_combobox.SelectedItem = "독서";
		}

		private void picture_picbox_Click(object sender, EventArgs e)
		{
			try
			{
				using (FileStream mystream = new FileStream("covers/빈화면.png", FileMode.Open))
				{
					picture_picbox.Image = Image.FromStream(mystream);
				}

				Directory.CreateDirectory("_resized_picture");
				Directory.Delete("_resized_picture", true);

				picture_dir_listbox.Items.Clear();

				OpenFileDialog ofd = new OpenFileDialog();

				ofd.Filter = "사진만 (png)|*.png|사진만 (jpg)|*.jpg|사진만 (all)|*.*";
				ofd.Title = "사진 선택좀";
				ofd.Multiselect = true;
				ofd.ShowDialog();

				string[] pic_dir = ofd.FileNames;

				pic_dir_len = pic_dir.Length;

				if (cut_radiobutton.Checked == true)
				{
					for (int i = 0; i < pic_dir_len; ++i)
					{
						Mat picture_image = new Mat();
						Mat _picture_image = new Mat();
						Mat img = Cv2.ImRead(pic_dir[i].ToString());
						Mat dst = new Mat();

						if (img.Cols > 950 && img.Rows > 1200)
						{
							float wRate = (950.0f / img.Cols);
							float hRate = (1200.0f / img.Rows);

							if (wRate < hRate)
							{
								Cv2.Resize(img, dst, new OpenCvSharp.Size(img.Cols * hRate, img.Rows * hRate));
								img = dst;
							}

							else
							{
								Cv2.Resize(img, dst, new OpenCvSharp.Size(img.Cols * wRate, img.Rows * wRate));
								img = dst;
							}
						}

						if (img.Cols < 950)
						{
							float rate = (950.0f / img.Cols);
							Cv2.Resize(img, dst, new OpenCvSharp.Size(950, img.Rows * rate));
							img = dst;
						}

						if (img.Rows < 1200)
						{
							float rate = (1200.0f / img.Rows);
							Cv2.Resize(img, dst, new OpenCvSharp.Size(img.Cols * rate, 1200));
							img = dst;
						}

						Rect rect = new Rect((img.Cols / 2) - 475, (img.Rows / 2) - 600, 950, 1200);
						picture_image = img.SubMat(rect);
						Cv2.Resize(picture_image, _picture_image, new OpenCvSharp.Size(323, 408));

						Directory.CreateDirectory("_resized_picture");
						Cv2.ImWrite("_resized_picture/resized_picture" + (i + 1).ToString() + "_preview.png", _picture_image);
						Cv2.ImWrite("_resized_picture/resized_picture" + (i + 1).ToString() + ".png", picture_image);

						picture_dir_listbox.Items.Add("_resized_picture/resized_picture" + (i + 1).ToString() + ".png");
						Cv2.WaitKey(0);
						Cv2.DestroyAllWindows();
					}

					using(FileStream mystream = new FileStream("_resized_picture/resized_picture" + pic_dir_len + "_preview.png", FileMode.Open))
					{
						picture_picbox.Image = Image.FromStream(mystream);
					}
				}

				else
				{
					for (int i = 0; i < pic_dir_len; ++i)
					{
						Mat picture_image = new Mat();
						Mat _picture_image = new Mat();
						Mat img = Cv2.ImRead(pic_dir[i].ToString());

						Cv2.Resize(img, picture_image, new OpenCvSharp.Size(950, 1200));
						Cv2.Resize(img, _picture_image, new OpenCvSharp.Size(323, 408));

						Directory.CreateDirectory("_resized_picture");
						Cv2.ImWrite("_resized_picture/resized_picture" + (i + 1).ToString() + "_preview.png", _picture_image);
						Cv2.ImWrite("_resized_picture/resized_picture" + (i + 1).ToString() + ".png", picture_image);

						picture_dir_listbox.Items.Add("_resized_picture/resized_picture" + (i + 1).ToString() + ".png");
						Cv2.WaitKey(0);
						Cv2.DestroyAllWindows();
					}

					using (FileStream mystream = new FileStream("_resized_picture/resized_picture" + pic_dir_len + "_preview.png", FileMode.Open))
					{
						picture_picbox.Image = Image.FromStream(mystream);
					}
				}
			}

			catch (Exception err)
			{
				MessageBox.Show(err.ToString(), "뭐함?");
			}
		}
		private void subject_combobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			subject = subject_combobox.SelectedItem.ToString();
		}
		private void picture_dir_listbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selected = picture_dir_listbox.SelectedItem?.ToString();

			if (selected != null && selected != "사진을 선택해주세요 (여러장 선택 가능)")
			{
				using (FileStream mystream = new FileStream(selected.Substring(0, selected.IndexOf(".png")) + "_preview.png", FileMode.Open))
				{
					picture_picbox.Image = Image.FromStream(mystream);
				}
			}
		}
		private void output_dir_button_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			fbd.Description = "폴더 선택좀";
			fbd.ShowDialog();

			output_dir = fbd.SelectedPath;
			output_dir_button.Text = output_dir;
		}
		private void run_button_Click(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < pic_dir_len; ++i)
				{
					Mat picture = Cv2.ImRead("_resized_picture/resized_picture" + (i + 1).ToString() + ".png");
					Mat mask = Cv2.ImRead("covers/" + subject + "/" + subject + "_mask.png");
					Mat cover = Cv2.ImRead("covers/" + subject + "/" + subject + "_cover.png");

					Mat result = new Mat();
					Mat _result = new Mat();

					Cv2.BitwiseAnd(mask, picture, _result);
					Cv2.Add(_result, cover, result);

					Directory.CreateDirectory(output_dir + "/result");
					Cv2.ImWrite(output_dir + "/result/result" + (i + 1).ToString() + ".png", result);
				}

				MessageBox.Show("ㅇㅇ", "다됨");
			}

			catch(Exception err)
			{
				MessageBox.Show(err.ToString(), "뭐함?");
			}
		}
	}
}
