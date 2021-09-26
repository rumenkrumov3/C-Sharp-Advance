using System;
using System.Collections.Generic;
using System.Text;

namespace SetsAndDictionaries
{
    public class Vlogger
    {
        public Vlogger()
        {
            Followers = new HashSet<string>();
            Following = new HashSet<string>();
        }
        public HashSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }
    }
}
