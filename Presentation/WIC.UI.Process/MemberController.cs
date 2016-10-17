using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WIC.Entities;

namespace WIC.UI.Process
{
    /// <summary>
    /// User Process Components used to abstract tasks from the UI used as a Controllers.  Entities serve as a model.
    /// The UI serves as a view.
    /// </summary>
    public class MemberController
    {
        public static string[] GetStates()
        {
            return Enum.GetNames(typeof(States));
        }
    }
}
