using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinker_Tailor
{
    class Solver<T> : ISolver<T>
    {
        public T[] Solve(int remove, params T[] arr)
        {
            int counter = 1;
            int index = 0;
            T[] result = arr;
            while (result.Length > 1)
            {
                if(index >= result.Length)
                {
                    index = 0;
                }
                for (int i = index; i < result.Length; i++)
                {
                    if (counter == remove)
                    {
                        counter = 1;
                        Resize(i, ref result);
                        break;
                    }
                    index++;
                    counter++;
                }
            }
            return result;
        }

        private void Resize(int index, ref T[] arr)
        {
            T[] temp = new T[arr.Length - 1];
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(i < index || index < i)
                {
                    temp[counter] = arr[i];
                    counter++;
                }
            }
            arr = temp;
        }
    }
}
