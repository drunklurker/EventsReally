using System;

namespace _10_Events
{
	public class ExitSubscriber
	{
		public void ExitProgram(object source, MyEventArgs e)
		{
			if (e.GetInfo() == '\n')
				Environment.Exit (0);
		}
	}
}

