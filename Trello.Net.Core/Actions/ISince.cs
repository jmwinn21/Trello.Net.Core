using System;

namespace Trello.Net
{
	public interface ISince
	{
		bool LastView { get; }
		DateTime Date { get; }
	}
}