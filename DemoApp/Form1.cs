using System.Windows.Forms;

namespace DemoApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			lblNormal.Text = RegistryCursor.GetCursorPath(RegistryCursor.Normal);
			lblHelp.Text = RegistryCursor.GetCursorPath(RegistryCursor.Help);
			lblWorkingInBackground.Text = RegistryCursor.GetCursorPath(RegistryCursor.WrkInBgnd);
			lblBusy.Text = RegistryCursor.GetCursorPath(RegistryCursor.Busy);
			lblPrecision.Text = RegistryCursor.GetCursorPath(RegistryCursor.Precision);
			lblText.Text = RegistryCursor.GetCursorPath(RegistryCursor.Text);
			lblHandwriting.Text = RegistryCursor.GetCursorPath(RegistryCursor.Pen);
			lblUnavailable.Text = RegistryCursor.GetCursorPath(RegistryCursor.Unvlble);
			lblVertical.Text = RegistryCursor.GetCursorPath(RegistryCursor.VertRez);
			lblHorizontal.Text = RegistryCursor.GetCursorPath(RegistryCursor.HorzRez);
			lblDiagonal1.Text = RegistryCursor.GetCursorPath(RegistryCursor.Dgnl1);
			lblDiagonal2.Text = RegistryCursor.GetCursorPath(RegistryCursor.Dgnl2);
			lblMove.Text = RegistryCursor.GetCursorPath(RegistryCursor.Move);
			lblAlternate.Text = RegistryCursor.GetCursorPath(RegistryCursor.Alt);
			lblLink.Text = RegistryCursor.GetCursorPath(RegistryCursor.Link);
			lblLocation.Text = RegistryCursor.GetCursorPath(RegistryCursor.Pin);
			lblPerson.Text = RegistryCursor.GetCursorPath(RegistryCursor.Person);
			lblScheme.Text = RegistryCursor.Scheme;
		}
	}
}
