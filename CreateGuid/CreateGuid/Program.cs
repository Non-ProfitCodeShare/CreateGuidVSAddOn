using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// This program is to be used as a visual studio external tool to generate CRM-friendly guids.
/// Author - Nolan Regenwether
/// No warranties - No returns. 
/// </summary>
namespace CreateGuid
{
	static class Program
	{
		
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
