using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICallProject.Models
{
    public class Root
    {
        public Location location { get; set; }
        public Current current { get; set; }
    }
}
