using System.Collections.Generic;
using Trello.Net.Internal;

namespace Trello.Net.Extensions
{
	public class AutoPagedNotifications : AutoPaged
	{
		private readonly INotifications _trelloNotifications;		

		internal AutoPagedNotifications(INotifications trelloNotifications, int pageSize)
			: base(pageSize)
		{
			_trelloNotifications = trelloNotifications;			
		}

		public IEnumerable<Notification> ForMe(IEnumerable<NotificationType> filter = null, ReadFilter readFilter = ReadFilter.All)
		{
			var currentPage = 0;
			return AutoPage(() => _trelloNotifications.ForMe(filter, readFilter, new Paging(_pageSize, currentPage++)));
		}
	}
}