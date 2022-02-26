using Microsoft.Win32;
using System.Collections.Generic;

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

	public const string Normal = "Normal Select",
		Help = "Help Select",
		WrkInBgnd = "Working In Background",
		Busy = "Busy",
		Precision = "Precision Select",
		Text = "Text Select",
		Pen = "Handwriting",
		Unvlble = "Unavailable",
		VertRez = "Vertical Resize",
		HorzRez = "Horizontal Resize",
		Dgnl1 = "Diagonal Resize 1",
		Dgnl2 = "Diagonal Resize 2",
		Move = "Move",
		Alt = "Alternate Select",
		Link = "Link Select",
		Pin = "Location Select",
		Person = "Person Select";

	/// <summary>
	/// The name of the current cursor scheme of the current user.
	/// </summary>
	public static string Scheme => cursorRegKey.GetValue("").ToString();

	/// <summary>
	/// The file path to the selected cursor in the cursor scheme.
	/// </summary>
	/// <param name="CursorName">The cursor to access</param>
	/// <returns>The selected cursor's file path</returns>
	public static string GetCursorPath(string CursorName) => cursors[CursorName].Path;
}
