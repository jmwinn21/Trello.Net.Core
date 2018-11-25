using System;

namespace Trello.Net
{
	public class TrelloException : Exception
	{
		public TrelloException(string message) : base(message)
		{			
		}
	}
}