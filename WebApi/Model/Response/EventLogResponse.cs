using System;

namespace WebApi.Model.Response
{
    public class EventLogResponse
    {
        public Guid Id { get; set; }
        public int CodeId { get; set; }
        public Decimal Value { get; set; }
    }
}
