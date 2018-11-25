namespace Trello.Net.Internal
{
	internal class MembersInvitedForBoardRequest : BoardsRequest
	{
		public MembersInvitedForBoardRequest(IBoardId board)
			: base(board, "membersInvited")
		{
			AddParameter("fields", "all");
		}
	}
}