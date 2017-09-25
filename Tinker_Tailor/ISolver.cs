using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinker_Tailor
{
    interface ISolver<T>
    {
        T[] Solve(T remove, params T[] arr);
    }
}
