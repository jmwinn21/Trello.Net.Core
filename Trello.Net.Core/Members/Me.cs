namespace Trello.Net
{
	public class Me : IMemberId
	{
		public string GetMemberId()
		{
			return "me";
		}
	}
}