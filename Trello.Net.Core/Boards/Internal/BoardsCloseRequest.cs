using RestSharp;

namespace Trello.Net.Internal
{
	internal class BoardsCloseRequest : BoardsRequest
	{
		public BoardsCloseRequest(IBoardId board)
			: base(board, "closed", Method.PUT)
		{
			this.AddValue("true");			
		}
	}
}