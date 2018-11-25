namespace Trello.Net
{
	public class TrelloUnauthorizedException : TrelloException
	{
		public TrelloUnauthorizedException(string message) : base(message)
		{			
		}
	}
}