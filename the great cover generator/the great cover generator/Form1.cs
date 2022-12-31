using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AdsJumboWinForm;

namespace the_great_cover_generator
{
	public partial class the_great_cover_generator : Form
	{
		string subject;
		string output_dir;

		int cnt_pic = 0;
		int pic_dir_len;


		public the_great_cover_generator()
		{
			InitializeComponent();
			adsbanner.ShowAd(728, 90, "p4678cjlfyac");
			subject_combobox.SelectedItem = "독서";
		}

		private void picture_picbox_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog ofd = new OpenFileDialog();

				if (cnt_pic == 1)
				{
					MessageBox.Show("프로그램을 껐다 켜지 않고 파일을 재선택 할 시에\n미리보기가 지1랄나는 버그가 있으니 양해좀ㅎ\n(미리보기만 그런거라 그냥 해도됨)", "ㅈㅅㅋㅋ");
				}
				cnt_pic = 1;

				ofd.Filter = "사진만|*.png|사진만|*.jpg|사진만|*.*";
				ofd.Title = "사진 선택좀";
				ofd.Multiselect = true;
				ofd.ShowDialog();

				string[] pic_dir = ofd.FileNames;

				picture_dir_listbox.Items.Clear();

				pic_dir_len = pic_dir.Length;

				if (cut_radiobutton.Checked == true)
				{
					for (int i = 0; i < pic_dir_len; ++i)
					{
						Mat picture_image = new Mat();
						Mat _picture_image = new Mat();
						Mat img = Cv2.ImRead(pic_dir[i].ToString());
						Mat dst = new Mat();

						while (true)
						{
							if (img.Cols < 800 | img.Rows < 1009)
							{
								Cv2.Resize(img, dst, new OpenCvSharp.Size(img.Cols * 2, img.Rows * 2));
								img = dst;
							}

							else if (img.Cols * 0.8 > 800 & img.Rows * 0.8 > 1009)
							{
								Cv2.Resize(img, dst, new OpenCvSharp.Size(img.Cols * 0.8, img.Rows * 0.8));
								img = dst;
							}

							else
							{
								break;
							}
						}

						Rect rect = new Rect((img.Cols / 2) - 400, (img.Rows / 2) - 504, 800, 1009);
						picture_image = img.SubMat(rect);
						Cv2.Resize(picture_image, _picture_image, new OpenCvSharp.Size(320, 400));

						Directory.CreateDirectory("_resized_picture");
						Cv2.ImShow("확인용", picture_image);
						Cv2.ImWrite("_resized_picture/resized_picture" + (i + 1).ToString() + "_preview.png", _picture_image);
						Cv2.ImWrite("_resized_picture/resized_picture" + (i + 1).ToString() + ".png", picture_image);

						picture_dir_listbox.Items.Add("_resized_picture/resized_picture" + (i + 1).ToString() + ".png");
						Cv2.WaitKey(0);
						Cv2.DestroyAllWindows();
					}

					picture_picbox.Image = Image.FromFile("_resized_picture/resized_picture" + pic_dir_len + "_preview.png");
				}

				else
				{
					for (int i = 0; i < pic_dir_len; ++i)
					{
						Mat picture_image = new Mat();
						Mat _picture_image = new Mat();
						Mat img = Cv2.ImRead(pic_dir[i].ToString());

						Cv2.Resize(img, picture_image, new OpenCvSharp.Size(800, 1009));
						Cv2.Resize(img, _picture_image, new OpenCvSharp.Size(320, 400));

						Directory.CreateDirectory("_resized_picture");
						Cv2.ImShow("확인용", picture_image);
						Cv2.ImWrite("_resized_picture/resized_picture" + (i + 1).ToString() + "_preview.png", _picture_image);
						Cv2.ImWrite("_resized_picture/resized_picture" + (i + 1).ToString() + ".png", picture_image);

						picture_dir_listbox.Items.Add("_resized_picture/resized_picture" + (i + 1).ToString() + ".png");
						Cv2.WaitKey(0);
						Cv2.DestroyAllWindows();
					}

					picture_picbox.Image = Image.FromFile("_resized_picture/resized_picture" + pic_dir_len + "_preview.png");
				}
			}

			catch (Exception err)
			{
				MessageBox.Show(err.ToString(), "뭐함?");

				cnt_pic = 0;
			}
		}
		private void subject_combobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			subject = subject_combobox.SelectedItem.ToString();
		}
		private void picture_dir_listbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selected = picture_dir_listbox.SelectedItem.ToString();

			picture_picbox.Image = Image.FromFile(selected.Substring(0, selected.IndexOf(".png")) + "_preview.png");
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

					Cv2.ImShow("완료!", result);
					Cv2.WaitKey(0);
					Cv2.DestroyAllWindows();

					Cv2.ImWrite(output_dir + "/result/result" + (i + 1).ToString() + ".png", result);
					Directory.CreateDirectory(output_dir + "/result");
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
