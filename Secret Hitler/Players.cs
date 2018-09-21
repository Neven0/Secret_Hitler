using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Hitler
{
    public class Players
    {
        public string Name;
        public bool IsFascist { get; set; }
        public bool IsLiberal { get; set; }
        public bool IsHitler { get; set; }
        public bool IsPresident { get; set; }
        public bool IsChancellor { get; set; }
        public bool IsNominated { get; set; }

        public Players(string name)
        {
            Name = name;
            IsFascist = false;
            IsLiberal = false;
            IsHitler = false;
            IsPresident = false;
            IsChancellor = false;
            IsNominated = false;
        }
    }

    
}
