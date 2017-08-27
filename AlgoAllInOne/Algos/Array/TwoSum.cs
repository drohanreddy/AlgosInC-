using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAllInOne.Algos.Array
{
    public class TwoSum
    {
        private int _target;
        private int[] _arr;
        public TwoSum(int[] arr, int target)
        {
            _arr = arr;
            _target = target;
        }

        /// <summary>
        /// Basic method using two for loops. Not optimum
        /// </summary>
        /// <returns>An array of indices</returns>
        public int[] basicMethod()
        {
            int[] output = new int[2];
            for (int i = 0; i < _arr.Length; i++)
            {
                for (int j = 1; j < _arr.Length; j++)
                {
                    if (_arr[i]+_arr[j] == _target && i != j)
                    {
                        if (i<j)
                        {
                            output[0] = i;
                            output[1] = j;
                        }
                        else
                        {
                            output[0] = j;
                            output[1] = i;
                        }
                       
                    }
                }
            }
            return output;
        }
    }
}
