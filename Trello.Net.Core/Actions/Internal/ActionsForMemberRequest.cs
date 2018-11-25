using System.Collections.Generic;

namespace Trello.Net.Internal
{
	internal class ActionsForMemberRequest : MembersRequest
	{
		public ActionsForMemberRequest(IMemberId member, ISince since, Paging paging, IEnumerable<ActionType> filter)
			: base(member, "actions")
		{
			this.AddTypeFilter(filter);
			this.AddSince(since);
			this.AddPaging(paging);
		}
	}
}