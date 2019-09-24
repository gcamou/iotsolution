using System;

namespace Core.Abstractions.Biz
{
    public class EventLogBiz : IBiz
    {
        public int CodeId { get; set; }
        public Decimal Value { get; set; }
    }
}