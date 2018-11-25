namespace Trello.Net.Internal
{
	internal class MembersForCardRequest : CardsRequest
	{
		public MembersForCardRequest(ICardId card)
			: base(card, "members")
		{
			this.AddRequiredMemberFields();
		}
	}
}