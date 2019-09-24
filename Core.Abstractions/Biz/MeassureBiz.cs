using System;

namespace Core.Abstractions.Biz
{
    public class MeassureBiz : IBiz
    {
        public int Id { get; set; }
        public DateTime TimeSpamp { get; set; }
        public DateTime Created { get; set; }
    }
}