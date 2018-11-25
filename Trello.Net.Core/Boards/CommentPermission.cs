using Newtonsoft.Json;
using Trello.Net.Internal;

namespace Trello.Net
{
	[JsonConverter(typeof(TrelloEnumConverter))]
	public enum CommentPermission
	{
		Unknown = 0,
		Disabled,
		Members,
		Observers,
		Org,
		Public
	}
}