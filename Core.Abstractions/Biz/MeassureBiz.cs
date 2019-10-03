using System;

namespace Core.Abstractions.Biz
{
    public class MeassureBiz : IBiz
    {
        public Guid Id { get; set; }
        public int CodeId { get; set; }
        public DateTime TimeSpamp { get; set; }
        public DateTime Created { get; set; }
    }
}