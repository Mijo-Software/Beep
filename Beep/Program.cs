using System;
using System.Windows.Forms;

namespace Beep
{
	/// <summary>
	/// Program class
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// Main entrance point of the application
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using BeepForm mainForm = new BeepForm();
			Application.Run(mainForm: mainForm);
		}
	}
}
