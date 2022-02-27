using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class RegistryCursor
{
	private static RegistryKey cursorRegKey = Registry.CurrentUser.OpenSubKey("Control Panel").OpenSubKey("Cursors");

	private static Dictionary<string, RegCursor> cursors = new Dictionary<string, RegCursor>
	{
		{ "Normal Select",         new RegCursor("Arrow",       cursorRegKey.GetValue("Arrow").ToString())        },
		{ "Help Select",           new RegCursor("Help",        cursorRegKey.GetValue("Help").ToString())         },
		{ "Working In Background", new RegCursor("AppStarting", cursorRegKey.GetValue("AppStarting").ToString())  },
		{ "Busy",                  new RegCursor("Wait",        cursorRegKey.GetValue("Wait").ToString())         },
		{ "Precision Select",      new RegCursor("Crosshair",   cursorRegKey.GetValue("Crosshair").ToString())    },
		{ "Text Select",           new RegCursor("IBeam",       cursorRegKey.GetValue("IBeam").ToString())        },
		{ "Handwriting",           new RegCursor("NWPen",       cursorRegKey.GetValue("NWPen").ToString())        },
		{ "Unavailable",           new RegCursor("No",          cursorRegKey.GetValue("No").ToString())           },
		{ "Vertical Resize",       new RegCursor("SizeNS",      cursorRegKey.GetValue("SizeNS").ToString())       },
		{ "Horizontal Resize",     new RegCursor("SizeWE",      cursorRegKey.GetValue("SizeWE").ToString())       },
		{ "Diagonal Resize 1",     new RegCursor("SizeNWSE",    cursorRegKey.GetValue("SizeNWSE").ToString())     },
		{ "Diagonal Resize 2",     new RegCursor("SizeNESW",    cursorRegKey.GetValue("SizeNESW").ToString())     },
		{ "Move",                  new RegCursor("SizeAll",     cursorRegKey.GetValue("SizeAll").ToString())      },
		{ "Alternate Select",      new RegCursor("UpArrow",     cursorRegKey.GetValue("UpArrow").ToString())      },
		{ "Link Select",           new RegCursor("Hand",        cursorRegKey.GetValue("Hand").ToString())         },
		{ "Location Select",       new RegCursor("Pin",         cursorRegKey.GetValue("Pin").ToString())          },
		{ "Person Select",         new RegCursor("Person",      cursorRegKey.GetValue("Person").ToString())       },
	};

	public enum CursorType
	{
		Normal_Select,
		Help_Select,
		Working_In_Background,
		Busy,
		Precision_Select,
		Text_Select,
		Handwriting,
		Unavailable,
		Vertical_Resize,
		Horizontal_Resize,
		Diagonal_Resize_1,
		Diagonal_Resize_2,
		Move,
		Alternate_Select,
		Link_Select,
		Location_Select,
		Person_Select,
	}

	/// <summary>
	/// The name of the current cursor scheme of the current user.
	/// </summary>
	public static string Scheme => cursorRegKey.GetValue("").ToString();

	/// <summary>
	/// The file path to the selected cursor in the cursor scheme.
	/// </summary>
	/// <param name="CursorType">The cursor to access</param>
	/// <returns>The selected cursor's file path</returns>
	public static string GetCursorPath(CursorType CursorType)
	{
		string curType1 = CursorType.ToString();
		string curType2 = curType1.Replace('_', ' ');

		return cursors[curType2].Path;
	}

	[DllImport("user32.dll")]
	private static extern IntPtr LoadCursorFromFile(string FileName);

	/// <summary>
	/// Loads the given cursor file into a new <see cref="Cursor"/> object with any color included in the file
	/// </summary>
	/// <param name="CursorFile">The cursor file to load</param>
	/// <returns>The cursor with any included color from the file</returns>
	public static Cursor LoadFromPath(string CursorFile)
	{
		try
		{
			IntPtr cursorHandle = LoadCursorFromFile(CursorFile);
			Cursor newCursor = new Cursor(cursorHandle);

			return newCursor;
		}
		catch
		{
			return Cursors.Arrow;
		}
	}
}
