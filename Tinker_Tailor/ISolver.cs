using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinker_Tailor
{
    interface ISolver<T>
    {
        void Solver(int remove, params T[] arr);
    }
}
