using System;

namespace Model.Abstractions.Entities
{
    public class EventLog
    {
        public EventLog()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
        public int CodeId { get; set; }
        public Decimal Value { get; set; }
    }
}