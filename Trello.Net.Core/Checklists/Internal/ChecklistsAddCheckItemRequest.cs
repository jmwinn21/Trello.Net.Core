using RestSharp;

namespace Trello.Net.Internal
{
	internal class ChecklistsAddCheckItemRequest : ChecklistsRequest
	{
		public ChecklistsAddCheckItemRequest(IChecklistId checklist, string name) 
			: base(checklist, "checkitems", Method.POST)
		{
			Guard.RequiredTrelloString(name, "name");
			AddParameter("name", name);
		}
	}
}