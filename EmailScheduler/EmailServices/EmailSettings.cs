using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailScheduler.EmailServices
{
    public class EmailSettings
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }

}
