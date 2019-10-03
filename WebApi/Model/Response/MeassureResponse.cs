using System;

namespace WebApi.Model.Response
{
    public class MeassureResponse
    {
        public Guid Id { get; set; }
        public int CodeId { get; set; }
        public DateTime TimeSpamp { get; set; }
        public DateTime Created { get; set; }
    }
}
