﻿using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;


namespace DefaultNamespace.HomeWork5
{
    public static class Extensions
    {
        public static T AddTo<T>(this T self, ICollection<T> coll)
        {
            {
                coll.Add(self);
                return self;
            }
        }

        public static string HowMuch(this string self)
        {
            int num;
            num = self.Length;
            return num.ToString();
        }

        public static string SortListNumbers(this List<int> list)
        {

            string s="";
            Dictionary<int,int> dictionary= new Dictionary<int,int>();
            foreach (var smt in list)
            {
                if (!dictionary.ContainsKey(smt))
                {
                    dictionary.Add(smt, 1);
                }
                else
                {
                    dictionary[smt]++;
                }
            }
            foreach (var number in dictionary)
            {
                s += $"{number.Key} встречается {number.Value} раз\n";
            }

            return s;
        }
    }
}