using System;

namespace Model.Abstractions.Entities
{
    public class Meassure
    {
        public Meassure()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
        public int CodeId { get; set; }
        public DateTime TimeSpamp { get; set; }
        public DateTime Created { get; set; }
    }
}