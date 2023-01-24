﻿using System;
using System.IO;
using System.Windows.Forms;

namespace the_great_cover_generator
{
	internal static class Program
	{
		/// <summary>
		/// 해당 애플리케이션의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new the_great_cover_generator());

			Directory.CreateDirectory("_resized_picture");
			Directory.Delete("_resized_picture", true);
		}
	}
}
