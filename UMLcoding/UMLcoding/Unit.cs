using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLcoding
{
    class Unit
    {
        public int durationinHrs { get; set; }

        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
}
