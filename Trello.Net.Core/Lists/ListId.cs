using Trello.Net.Internal;

namespace Trello.Net
{
	public class ListId : IListId
	{
		private readonly string _id;

		public ListId(string id)
		{
			Guard.NotNullOrEmpty(id, "id");

			_id = id;
		}

		public string Id
		{
			get { return _id; }
		}

		public string GetListId()
		{
			return Id;
		}
	}
}