using System.Collections.Generic;

namespace Trello.Net
{
	public class SearchFilter
	{		
		public IEnumerable<IBoardId> Boards { get; set; }
		public IEnumerable<IOrganizationId> Organizations { get; set; }
		public IEnumerable<ICardId> Cards { get; set; }
	}
}