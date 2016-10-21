using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIC.UI.Win.Views
{
    // marker interface
    public interface IView
    {        
        bool IsValid { get; set; }
    }
}
