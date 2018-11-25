using System;
using System.Globalization;
using RestSharp;

namespace Trello.Net.Internal
{
	internal class CardsChangeDueDateRequest : CardsRequest
	{
		public CardsChangeDueDateRequest(ICardId card, DateTimeOffset? due)
			: base(card, "due", Method.PUT)
		{
			var dueString = "";			
			if (due.HasValue)
				dueString = due.Value.ToString(CultureInfo.InvariantCulture);
			this.AddValue(dueString);
		}
	}
}