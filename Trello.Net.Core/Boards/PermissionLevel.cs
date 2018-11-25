using Newtonsoft.Json;
using Trello.Net.Internal;

namespace Trello.Net
{
	[JsonConverter(typeof(TrelloEnumConverter))]
	public enum PermissionLevel
	{
		Unknown = 0,
		Private,
		Org,
		Public
	}
}