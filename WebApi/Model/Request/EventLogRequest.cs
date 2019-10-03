using System;

namespace WebApi.Model.Request
{
    public class EventLogRequest
    {
        public Guid Id { get; set; }
        public int CodeId { get; set; }
        public Decimal Value { get; set; }
    }
}
