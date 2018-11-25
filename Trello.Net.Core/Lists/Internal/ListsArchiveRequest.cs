using RestSharp;

namespace Trello.Net.Internal
{
	internal class ListsArchiveRequest : ListsRequest
	{
		public ListsArchiveRequest(IListId list)
			: base(list, "closed", Method.PUT)
		{
			this.AddValue("true");			
		}
	}
}