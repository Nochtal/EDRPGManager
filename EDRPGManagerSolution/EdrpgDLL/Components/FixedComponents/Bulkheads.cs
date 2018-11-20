using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdrpgDLL.Components.FixedComponents
{
    public class Bulkheads
    {
        public Bulkheads(string ship, int reinforced, int military)
        {
            Ship = ship;
            ReinforcedAlloy = reinforced;
            MilitaryGradeComposite = military;
        }

        public string Ship { get { return Ship; } set { Ship = value; } }
        public int ReinforcedAlloy { get { return ReinforcedAlloy; } set { ReinforcedAlloy = value; } }
        public int MilitaryGradeComposite { get { return MilitaryGradeComposite; } set { MilitaryGradeComposite = value; } }
    }
}
