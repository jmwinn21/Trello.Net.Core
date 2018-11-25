using RestSharp;

namespace Trello.Net.Internal
{
	internal class CardsRemoveMemberRequest : CardsRequest
	{
		public CardsRemoveMemberRequest(ICardId card, IMemberId member)
			: base(card, "members/{idMember}", Method.DELETE)
		{
			Guard.NotNull(member, "member");
			AddParameter("idMember", member.GetMemberId(), ParameterType.UrlSegment);
		}
	}
}