using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.HomeWork5
{
    public class HomeWork5 : MonoBehaviour
    {
        private string _strLength;
        private string s;
        private void Start()
        {
            RandomList.RandomFill();
            StringLength();
            AddToList();
            NumbersCounter();
            Debug.Log(RandomList._randomStrings[0]);
            Debug.Log(RandomList._stringRnd);
            Debug.Log(_strLength);
            Debug.Log(s);
        }

        private void AddToList()
        {
            var list = new List<string>();
            list.Add($"Строка: {RandomList._stringRnd} содержит {_strLength} символов");
            $"Строка {RandomList._stringRnd} содержит {_strLength} символов".AddTo(list).AddTo(RandomList._randomStrings);
        }

        private void StringLength()
        {
            _strLength = RandomList._stringRnd.HowMuch();
        }

        private void NumbersCounter()
        {
            s = RandomList._Ints.SortListNumbers();
        }
        
    }
}