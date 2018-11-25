using RestSharp;

namespace Trello.Net.Internal
{
	internal class CardsAddChecklistRequest : CardsRequest
	{
		public CardsAddChecklistRequest(ICardId card, IChecklistId checklist)
			: base(card, "checklists", Method.POST)
		{
			Guard.NotNull(checklist, "checklist");
			this.AddValue(checklist.GetChecklistId());
		}
	}
}