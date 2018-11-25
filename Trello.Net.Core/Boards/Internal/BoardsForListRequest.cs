namespace Trello.Net.Internal
{
	internal class BoardsForListRequest : ListsRequest
	{
		public BoardsForListRequest(IListId list)
			: base(list, "board")
		{
		}
	}
}