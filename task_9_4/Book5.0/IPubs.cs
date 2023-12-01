using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book5._0
{
    interface IPubs
    {
        (string title, bool isSubscription) subscription();
        bool isSubscription { get; set; }
    }
}
