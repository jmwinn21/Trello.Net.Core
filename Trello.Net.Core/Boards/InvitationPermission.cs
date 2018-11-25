using Newtonsoft.Json;
using Trello.Net.Internal;

namespace Trello.Net
{
	[JsonConverter(typeof(TrelloEnumConverter))]
	public enum InvitationPermission
	{
		Unknown = 0,
		Members,
		Owners,
        Admins
	}
}