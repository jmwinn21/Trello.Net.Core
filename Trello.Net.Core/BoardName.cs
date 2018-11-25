namespace Trello.Net
{
	public class BoardName : IBoardId
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string ShortLink { get; set; }

		public string GetBoardId()
		{
			return Id;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}