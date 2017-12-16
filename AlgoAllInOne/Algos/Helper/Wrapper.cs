using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAllInOne.Algos.Helper
{
    public static class Wrapper
    {
        public static K MethodCall<T, K>(Func<T,K> myFunc, T c){
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var outp = myFunc(c);
                sw.Stop();
                Console.WriteLine($"method {myFunc.Method.Name} executed with time {sw.Elapsed}");
                return outp;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                return default(K);
            }
        }
        public static T MethodCall<T>(Func<T> myFunc)
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var res = myFunc();
                
                sw.Stop();
                Console.WriteLine($"method {myFunc.Method.Name} executed with time {sw.Elapsed}");
                return res;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                return default(T);
            }
        }
    }
}
