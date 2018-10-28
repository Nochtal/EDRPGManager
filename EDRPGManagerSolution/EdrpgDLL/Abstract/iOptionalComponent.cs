using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdrpgDLL.Abstract
{
    interface iOptionalComponent : iComponent
    {
        /// <summary>
        /// Military Component Checksum
        /// True = is military component type
        /// False = is not military component type
        /// Checksum for Optional Slots that are
        /// restricted to Military Components
        /// </summary>
        
        int PowerCost { get; set; }
        
        bool Military { get; set; }
    }
}
