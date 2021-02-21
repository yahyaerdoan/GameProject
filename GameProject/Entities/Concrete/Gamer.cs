using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities.Concrete
{
    public class Gamer
    {
        public int GamerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long IdentityNumber { get; set; }
    }
}
