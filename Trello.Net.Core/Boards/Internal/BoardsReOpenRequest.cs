using RestSharp;

namespace Trello.Net.Internal
{
	internal class BoardsReOpenRequest : BoardsRequest
	{
		public BoardsReOpenRequest(IBoardId board)
			: base(board, "closed", Method.PUT)
		{
			this.AddValue("false");			
		}
	}
}