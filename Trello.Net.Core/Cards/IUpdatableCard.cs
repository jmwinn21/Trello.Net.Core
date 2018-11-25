using System;
using System.Collections.Generic;

namespace Trello.Net
{
	public interface IUpdatableCard
	{
		string Id { get; }
		string Name { get; }
		string Desc { get; }
		bool Closed { get; }
		string IdList { get; }
		DateTime? Due { get; }
        IEnumerable<Color> LabelColors { get; }
	}
}