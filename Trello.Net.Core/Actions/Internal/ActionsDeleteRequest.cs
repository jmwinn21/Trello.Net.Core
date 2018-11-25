using RestSharp;

namespace Trello.Net.Internal
{
	internal class ActionsDeleteRequest : ActionsRequest
	{
        public ActionsDeleteRequest(IActionId action)
            : base(action.GetActionId(), Method.DELETE)
		{
		}
	}
}