using RestSharp;

namespace Trello.Net.Internal
{
	internal class BoardsChangeNameRequest : BoardsRequest
	{
		public BoardsChangeNameRequest(IBoardId board, string name)
			: base(board, "name", Method.PUT)
		{
			Guard.RequiredTrelloString(name, "name");

			this.AddValue(name);			
		}
	}
}