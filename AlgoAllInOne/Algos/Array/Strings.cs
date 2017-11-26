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
            int len1 = one.Length;
            int len2 = two.Length;
            bool str2ls = len1 > len2;
            int diff = str2ls ? len1 - len2 : len2 - len1;
            if (diff <=1 )
            {
                if (str2ls)
                {
                    int changes = 0;
                    int j = 0;
                    for (int i = 0; i < len2; i++)
                    {
                        if (one[i] != two[j])
                        {
                            changes++;
                            if (changes > 1)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            j++;
                        }
                    }
                }
                else
                {
                    int changes = 0;
                    int j = 0;
                    for (int i = 0; i < len1; i++)
                    {
                        if (two[i] != one[j])
                        {
                            changes++;
                            if (changes > 1)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            j++;
                        }
                    }
                }

            }
            else
            {
                return false;
            }
            return true;
        }

        public static string Compress(string s)
        {
            int len = s.Length;
            StringBuilder cmrs = new StringBuilder();
            int i = 0;
            while (i<len)
            {
                char tChar = s[i];
                int tCount = 1;
                for (int j = i+1; j < len; j++)
                {
                    if (tChar == s[j])
                    {
                        i = j;
                        tCount++;
                    }
                    else
                    {
                        cmrs.Append(tChar);
                        cmrs.Append(tCount);
                        i++;
                        break;
                    }
                }
                if (i == len - 1)
                {
                    cmrs.Append(tChar);
                    cmrs.Append(tCount);
                    i++;
                }
            }
            string compressed = cmrs.ToString();
            return compressed.Length < len? compressed: s;
        }
    }
}
