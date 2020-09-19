using System;
using System.Collections.Generic;

namespace Dockersampleconfig.Models
{
    public partial class Usercredentials
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
