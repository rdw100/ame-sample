using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIC.Entities
{
    public enum EligibleStatus: byte
    {
        Categorical,
        Residential,
        Income,
        Nutritional
    }
}
