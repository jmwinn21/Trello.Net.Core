namespace Trello.Net.Internal
{
	internal class CardsForBoardRequest : BoardsRequest
	{
		public CardsForBoardRequest(IBoardId board, BoardCardFilter filter)
			: base(board, "cards")
		{
			this.AddCommonCardParameters();
			this.AddFilter(filter);
		}
	}
}