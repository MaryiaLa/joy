using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Joy
{
	public class Joystick
	{
		public Joystick()
		{
			jsx.dwSize = Marshal.SizeOf(jsx);
			jsx.dwFlags = 255;
			jsx.dwButtons = 11;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct JOYINFOEX
		{
			public int dwSize; // Size, in bytes, of this structure.
			public int dwFlags; // Flags indicating the valid information returned in this structure.
			public int dwXpos; // Current X-coordinate.
			public int dwYpos; // Current Y-coordinate.
			public int dwZpos; // Current Z-coordinate.
			public int dwRpos; // Current position of the rudder or fourth joystick axis.
			public int dwUpos; // Current fifth axis position.
			public int dwVpos; // Current sixth axis position.
			public int dwButtons; // Current state of the 32 joystick buttons (bits)
			public int dwButtonNumber; // Current button number that is pressed.
			public int dwPOV; // Current position of the point-of-view control (0..35,900, deg*100)
			public int dwReserved1; // Reserved; do not use.
			public int dwReserved2; // Reserved; do not use.
		}
		//
		[StructLayout(LayoutKind.Sequential)]
		public struct JOYINFO
		{
			public int wXpos; // Current X-coordinate.
			public int wYpos; // Current Y-coordinate.
			public int wZpos; // Current Z-coordinate.
			public int wButtons; // Current state of joystick buttons.
		}

		//
		[DllImport("winmm.dll", CallingConvention = CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
		public static extern int joyGetNumDevs();
		[DllImport("winmm.dll", CallingConvention = CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
		public static extern int joyGetPos(int uJoyID, ref JOYINFO pji);
		[DllImport("winmm.dll", CallingConvention = CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
		public static extern int joyGetPosEx(int uJoyID, ref JOYINFOEX pji);
		//
		public JOYINFO js;
		public JOYINFOEX jsx;
		public bool joyEx;
		public int joyId;

		public bool CheckIfIsConnected()
		{
			for (int i = 0, l = joyGetNumDevs(); i < l; i++)
			{
				if (joyGetPos(i, ref js) == 0)
				{
					joyId = i;
					joyEx = false;
				}
				if (joyGetPosEx(i, ref jsx) == 0)
				{
					joyId = i;
					joyEx = true;
				}
			}

			return joyEx;
		}

		public int CheckWhichButtonIsClicked()
		{
			if (joyEx)
			{
				joyGetPos(0, ref js);
				return js.wButtons;
			}

			return 0;
		}

		public bool CheckIfUpButtonIsClicked()
		{
			if (joyEx)
			{
				joyGetPos(0, ref js);
				return js.wYpos == 0;
			}

			return false;
		}
	}
}
