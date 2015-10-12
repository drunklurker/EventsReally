using System;

namespace _10_Events
{
	public class ThreeSubscriber
	{
		//actual method
		public void key3Pressed(object source, MyEventArgs e)
		{
			Console.WriteLine ("Key {0} was pressed", e.GetInfo());
		}
	}
}

