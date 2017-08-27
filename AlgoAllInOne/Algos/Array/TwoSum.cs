using System;
using System.Collections;
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


        #region approach  
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
                        return output;
                    }
                }
            }
            return output;
        }

        /// <summary>
        ///  Uses hashtable to process the array
        /// </summary>
        /// <returns>>An array of indices</returns>
        public int[] aBetterApproach()
        {
            int[] output = new int[2];
            Hashtable memoized = new Hashtable();
            for (int i = 0; i < _arr.Length; i++)
            {
                int diff = _target - _arr[i];
                if (!memoized.ContainsKey(diff))
                {
                    memoized.Add(diff, i);
                }
                else
                {
                    memoized[diff] = i;
                }
            }
            for (int i = 0; i < _arr.Length; i++)
            {
                if (memoized.ContainsKey(_arr[i]))
                {
                    int j = (int)memoized[_arr[i]];
                    if (i != j)
                    {
                        if (i < j)
                        {
                            output[0] = i;
                            output[1] = j;
                        }
                        else
                        {
                            output[0] = j;
                            output[1] = i;
                        }
                        return output;
                    }

                }
            }
            return output;
        }
        #endregion
    }
}
