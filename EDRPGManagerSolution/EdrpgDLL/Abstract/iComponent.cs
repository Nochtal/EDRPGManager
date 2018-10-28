using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdrpgDLL.Abstract
{
    interface iComponent
    {
        string Name { get; set; }
        int Size { get; set; }
        char Class { get; set; }
        int Cost { get; set; }
        int Strength { get; set; }
    }
}
