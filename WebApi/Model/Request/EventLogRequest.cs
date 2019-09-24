using System;

namespace WebApi.Model.Request
{
    public class EventLogRequest
    {
        public int CodeId { get; set; }
        public Decimal Value { get; set; }
    }
}
