using System;

namespace _10_Events
{
	public class MyEventArgs : EventArgs
	{
		private char EventInfo;
		public MyEventArgs(char c)
		{
			EventInfo = c;
		}
		public char GetInfo()
		{
			return EventInfo;
		}
	}

	public delegate void KeyPressedHandler(object source, MyEventArgs e);

	public class KeyboardManager
	{
		private char c;
		public event KeyPressedHandler key3Pressed;
		public event KeyPressedHandler key5Pressed;
		public event KeyPressedHandler numberPressed;
		public event KeyPressedHandler anyKeyPressed;
		public event KeyPressedHandler checkExit;
		public void HandleKey()
		{
			c = Console.ReadKey(true).KeyChar;
			MyEventArgs e = new MyEventArgs (c);
			if (c == '3')
				key3Pressed (this, e);
			if (c == '5')
				key5Pressed (this, e);
			if (c >= '0' && c <= '9')
				numberPressed (this, e);
			anyKeyPressed (this, e);
			checkExit (this, e);
		}
	}
}

