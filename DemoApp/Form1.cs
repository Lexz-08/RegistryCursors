using System.Windows.Forms;

namespace DemoApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			lblNormal.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Normal_Select);
			lblHelp.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Help_Select);
			lblWorkingInBackground.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Working_In_Background);
			lblBusy.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Busy);
			lblPrecision.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Precision_Select);
			lblText.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Text_Select);
			lblHandwriting.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Handwriting);
			lblUnavailable.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Unavailable);
			lblVertical.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Vertical_Resize);
			lblHorizontal.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Horizontal_Resize);
			lblDiagonal1.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Diagonal_Resize_1);
			lblDiagonal2.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Diagonal_Resize_2);
			lblMove.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Move);
			lblAlternate.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Alternate_Select);
			lblLink.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Link_Select);
			lblLocation.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Location_Select);
			lblPerson.Text = RegistryCursor.GetCursorPath(RegistryCursor.CursorType.Person_Select);
			lblScheme.Text = RegistryCursor.Scheme;

			lblNormal.Cursor = RegistryCursor.LoadFromPath(lblNormal.Text);
			lblHelp.Cursor = RegistryCursor.LoadFromPath(lblHelp.Text);
			lblWorkingInBackground.Cursor = RegistryCursor.LoadFromPath(lblWorkingInBackground.Text);
			lblBusy.Cursor = RegistryCursor.LoadFromPath(lblBusy.Text);
			lblPrecision.Cursor = RegistryCursor.LoadFromPath(lblPrecision.Text);
			lblText.Cursor = RegistryCursor.LoadFromPath(lblText.Text);
			lblHandwriting.Cursor = RegistryCursor.LoadFromPath(lblHandwriting.Text);
			lblUnavailable.Cursor = RegistryCursor.LoadFromPath(lblUnavailable.Text);
			lblVertical.Cursor = RegistryCursor.LoadFromPath(lblVertical.Text);
			lblHorizontal.Cursor = RegistryCursor.LoadFromPath(lblHorizontal.Text);
			lblDiagonal1.Cursor = RegistryCursor.LoadFromPath(lblDiagonal1.Text);
			lblDiagonal2.Cursor = RegistryCursor.LoadFromPath(lblDiagonal2.Text);
			lblMove.Cursor = RegistryCursor.LoadFromPath(lblMove.Text);
			lblAlternate.Cursor = RegistryCursor.LoadFromPath(lblAlternate.Text);
			lblLink.Cursor = RegistryCursor.LoadFromPath(lblLink.Text);
			lblLocation.Cursor = RegistryCursor.LoadFromPath(lblLocation.Text);
			lblPerson.Cursor = RegistryCursor.LoadFromPath(lblPerson.Text);
		}
	}
}
