using System;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


namespace DefaultNamespace.HomeWork5
{
    public class RandomList
    {
        private int _rndNumber1;
        public static string _stringRnd;
        public static List<string> _randomStrings = new List<string>();
        public static List<int> _Ints = new List<int>();
        private static Random _randomrnd;

        public static string RandomFill()
        {
            _randomrnd = new Random();
            int m;
            m = _randomrnd.Next(5, 50);
            for (int i = 0; i < m; i++)
            {
                string n = _randomrnd.Next(0, 3).ToString();
                switch (n)
                {
                    case "0":
                        _stringRnd += _randomrnd.Next(10).ToString();
                        break;
                    case "1":
                        _stringRnd += Convert.ToChar(_randomrnd.Next(65, 88));
                        break;
                    case "2":
                        _stringRnd += Convert.ToChar(_randomrnd.Next(97, 122));
                        break;
                }
            }

            for (int i = 0; i < m; i++)
            {
                _Ints.Add(_randomrnd.Next(0,50));
            }
            return _stringRnd;
        }
    }
}