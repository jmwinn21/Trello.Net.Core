using RestSharp;

namespace Trello.Net.Internal
{
	internal class CardsMoveRequest : CardsRequest
	{
		public CardsMoveRequest(ICardId card, IListId list)
			: base(card, "idList", Method.PUT)
		{
			Guard.NotNull(list, "list");
			this.AddValue(list.GetListId());
		}
	}
}