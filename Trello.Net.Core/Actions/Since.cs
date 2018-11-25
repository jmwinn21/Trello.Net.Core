using System;
using Trello.Net.Internal;

namespace Trello.Net
{
	public static class Since
	{
		public static ISince LastView { get { return new SinceLastView();} }
		public static ISince Date(DateTime date) { return new SinceDate(date); }
	}
}