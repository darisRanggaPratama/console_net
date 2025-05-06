using System;
using System.Windows.Forms;


namespace CRUD_MYSQL
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Display());
		}
	}
}
