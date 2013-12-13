using System;
using Gtk;

namespace TraderUI
{
	class MainClass
	{
		delegate void run1();
		run1 t;
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
		public void Queue(int Number)
		{
			for (int i = 0; i < Number; i++) {
			}
		}

	}
}
