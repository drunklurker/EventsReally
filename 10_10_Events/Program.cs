using System;

namespace _10_Events
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			KeyboardManager keyboardManager = new KeyboardManager ();
			ThreeSubscriber threeSubsriber = new ThreeSubscriber ();
			FiveSubscriber fiveSubscriber = new FiveSubscriber ();
			NumberSubscriber numberSubscriber = new NumberSubscriber ();
			AnyKeySubscriber anyKeySubscriber = new AnyKeySubscriber ();
			ExitSubscriber exitSubscriber = new ExitSubscriber ();

			keyboardManager.key3Pressed += new KeyPressedHandler (threeSubsriber.key3Pressed);
			keyboardManager.key5Pressed += new KeyPressedHandler (fiveSubscriber.key5Pressed);
			keyboardManager.numberPressed += new KeyPressedHandler (numberSubscriber.numberPressed);
			keyboardManager.anyKeyPressed += new KeyPressedHandler (anyKeySubscriber.anyKeyPressed);
			keyboardManager.checkExit += new KeyPressedHandler (exitSubscriber.ExitProgram);

			while (true)
			{
				keyboardManager.HandleKey ();
			}
		}
	}
}
