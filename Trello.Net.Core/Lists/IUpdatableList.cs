namespace Trello.Net
{
	public interface IUpdatableList
	{
		string Id { get; }
		string Name { get; }
		bool Closed { get; }
	}
}