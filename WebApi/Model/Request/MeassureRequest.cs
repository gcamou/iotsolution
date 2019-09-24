using System;

namespace WebApi.Model.Request
{
    public class MeassureRequest
    {
        public int Id { get; set; }
        public DateTime TimeSpamp { get; set; }
        public DateTime Created { get; set; }
    }
}