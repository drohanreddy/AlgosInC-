using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAllInOne.Algos.Array
{
    public static class Strings
    {
        public static bool isPermution(string one, string two)
        {
            Dictionary<char , int> oneDict = new Dictionary<char, int>();
            Dictionary<char, int> twoDict = new Dictionary<char, int>();
            foreach (char item in one)
            {
                if (oneDict.ContainsKey(item))
                {
                    oneDict[item]++;
                }
                else
                {
                    oneDict.Add(item, 1);
                }
            }
            foreach (char item in two)
            {
                if (twoDict.ContainsKey(item))
                {
                    twoDict[item]++;
                }
                else
                {
                    twoDict.Add(item, 1);
                }
                if (!oneDict.ContainsKey(item))
                {
                    return false;
                }
                else
                {
                    if (oneDict[item]< twoDict[item])
                    {
                        return false;
                    }
                }
            }
            if (oneDict.Keys.Count != twoDict.Keys.Count)
            {
                return false;

            }
            foreach (var item in twoDict)
            {
                var key = item.Key;
                if (!oneDict.ContainsKey(key))
                {
                    return false;
                }
                else
                {
                    if (oneDict[key] != twoDict[key])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static string urlify(string input, int actualLength)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < actualLength; i++)
            {
                if (input[i] !=' ')
                {
                    builder.Append(input[i]);
                }
                else
                {
                    builder.Append("%20");
                }
            }
            return builder.ToString();
        }

        public static bool palindromePermution(string input)
        {
            input = input.ToLower();
            Dictionary<char,int> dictionary = new Dictionary<char, int>();
            foreach (var item in input)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else if(item != ' ')
                {
                    dictionary.Add(item, 1);
                }
            }
            int missedItems = 0;
            foreach (var item in dictionary)
            {
                if (item.Value%2 != 0)
                {
                    missedItems++;
                }
                if (missedItems > 1)
                {
                    return false;
                }

            }
            return true;
        }

        public static bool OneAway(string one, string two)
        {
            Dictionary<char, int> oneDict = new Dictionary<char, int>();
            Dictionary<char, int> twoDict = new Dictionary<char, int>();
            int operations = 0;
            foreach (char item in one)
            {
                if (oneDict.ContainsKey(item))
                {
                    oneDict[item]++;
                }
                else
                {
                    oneDict.Add(item, 1);
                }
            }
            foreach (char item in two)
            {
                if (twoDict.ContainsKey(item))
                {
                    twoDict[item]++;
                }
                else
                {
                    twoDict.Add(item, 1);
                }
            }

            return true;
        }
    }
}
