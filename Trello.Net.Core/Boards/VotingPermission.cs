using Newtonsoft.Json;
using Trello.Net.Internal;

namespace Trello.Net
{
	[JsonConverter(typeof(TrelloEnumConverter))]
	public enum VotingPermission
	{
		Unknown = 0,
		Disabled,
		Members,
		Org,
		Public
	}
}