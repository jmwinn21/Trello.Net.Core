namespace Trello.Net.Internal
{
	internal class ChecklistsForBoardRequest : BoardsRequest
	{
		public ChecklistsForBoardRequest(IBoardId board)
			: base(board, "checklists")
		{
		}
	}
}