using System;

namespace _10_Events
{
	public class FiveSubscriber
	{
		public void key5Pressed(object source, MyEventArgs e)
		{
			Console.WriteLine ("Key {0} was pressed", e.GetInfo());
		}
	}
}

