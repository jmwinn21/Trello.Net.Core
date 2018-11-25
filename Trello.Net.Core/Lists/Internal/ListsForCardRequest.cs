namespace Trello.Net.Internal
{
	internal class ListsForCardRequest : CardsRequest
	{
		public ListsForCardRequest(ICardId card)
			: base(card, "list")
		{
		}
	}
}