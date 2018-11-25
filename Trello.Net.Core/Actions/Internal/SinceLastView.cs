using System;

namespace Trello.Net.Internal
{
	internal class SinceLastView : ISince
	{
		public bool LastView
		{
			get { return true; }
		}

		public DateTime Date
		{
			get { return DateTime.MinValue; }
		}
	}
}