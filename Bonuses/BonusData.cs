using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

namespace DefaultNamespace.Bonuses
{
    [CreateAssetMenu(fileName = "BonusSettings", menuName = "BonusSettings", order = 0)]
    public sealed class BonusData : ScriptableObject
    {
        [Serializable]
        public struct BonusInfo
        {
            public BonusType Type;
            public BonusProvider BonusPrefab;
        }
        
        [SerializeField] private List<BonusInfo> _bonusInfos;

        public BonusProvider GetBonus(BonusType type)
        {
            var _bonusInfo = _bonusInfos.First(info => info.Type == type);
            return _bonusInfo.BonusPrefab;
        }

    }
}
