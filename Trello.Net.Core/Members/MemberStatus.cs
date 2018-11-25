using Newtonsoft.Json;
using Trello.Net.Internal;

namespace Trello.Net
{
	[JsonConverter(typeof(TrelloEnumConverter))]
	public enum MemberStatus
	{
		Unknown = 0,
		Active,
		Idle,
		Disconnected
	}
}