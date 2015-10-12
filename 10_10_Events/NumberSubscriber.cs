using System;

namespace _10_Events
{
	public class NumberSubscriber
	{
		public void numberPressed(object source, MyEventArgs e)
		{
			Console.WriteLine ("Key {0} was pressed", e.GetInfo());
		}
	}
}

