using System;

namespace _10_Events
{
	public class AnyKeySubscriber
	{
		public void anyKeyPressed(object source, MyEventArgs e)
		{
			Console.WriteLine ("Key {0} was pressed", e.GetInfo());
		}
	}
}

