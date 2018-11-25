namespace Trello.Net.Internal
{
	internal class ChecklistsForCardRequest : CardsRequest
	{
		public ChecklistsForCardRequest(ICardId card)
			: base(card, "checklists")
		{
		}
	}
}