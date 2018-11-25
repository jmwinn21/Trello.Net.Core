using Trello.Net.Internal;

namespace Trello.Net
{
	public class CardId : ICardId
	{
		private readonly string _id;

		public CardId(string id)
		{
			Guard.NotNullOrEmpty(id, "id");

			_id = id;
		}

		public string Id
		{
			get { return _id; }
		}

		public string GetCardId()
		{
			return Id;
		}
	}
}