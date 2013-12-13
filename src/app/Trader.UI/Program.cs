using System;
using Gtk;

namespace TraderUI
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Hello
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}

		private void Test ()
		{
			int number = 0;
		}
		public ActionResult Help()
		{
			return RedirectToAction ("Help");
		}

	}
}
