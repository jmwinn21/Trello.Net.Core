using RestSharp;

namespace Trello.Net.Internal
{
	internal class CardsRemoveLabelRequest : CardsRequest
	{
		public CardsRemoveLabelRequest(ICardId card, Color color)
			: base(card, "labels/{color}", Method.DELETE)
		{
			AddParameter("color", color.ToTrelloString(), ParameterType.UrlSegment);
		}
	}
}