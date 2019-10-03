using System;

namespace WebApi.Model.Request
{
    public class MeassureRequest
    {
        public Guid Id { get; set; }
        public int CodeId { get; set; }
        public DateTime TimeSpamp { get; set; }
        public DateTime Created { get; set; }
    }
}