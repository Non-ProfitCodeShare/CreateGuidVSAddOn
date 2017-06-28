using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateGuid
{
	public partial class Form1 : Form
	{
		Guid guidPrg { get; set; }
		public Form1()
		{
			InitializeComponent();
			this.generateGuid();
			GuidTextBox.Text = guidPrg.ToString();

		}

		private void GuidTextBox_TextChanged(object sender, EventArgs e)
		{
			GuidTextBox.Text = String.Format(GuidTextBox.Text);
		}

		private void genGuid_Click(object sender, EventArgs e)
		{
			this.generateGuid();
		}

		private void generateGuid()
		{
			guidPrg = Guid.NewGuid();
			GuidTextBox.Text = String.Format(guidPrg.ToString());
		}

		private void copyToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(guidPrg.ToString());
		}

		private void quitBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
