using Trello.Net.Internal;

namespace Trello.Net
{
	public class ChecklistId : IChecklistId
	{
		private readonly string _id;

		public ChecklistId(string id)
		{
			Guard.NotNullOrEmpty(id, "id");

			_id = id;
		}

		public string Id
		{
			get { return _id; }
		}

		public string GetChecklistId()
		{
			return Id;
		}
	}
}