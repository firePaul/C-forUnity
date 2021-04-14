using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

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
            public float x, y, z;
        }
        
        [SerializeField] private List<BonusInfo> _bonusInfos;

        private BonusData _bonus;
        public BonusProvider GetBonus(BonusType type)
        {
            var _bonusInfo = _bonusInfos.First(info => info.Type == type);
            return _bonusInfo.BonusPrefab;
        }
        public BonusData Bonus
        {
            get
            {
                if (_bonus == null)
                {
                    _bonus = Load<BonusData>("BonusSettings");
                }

                return _bonus;
            }
        }
        private T Load<T>(string resourcesPath) where T : Object => 
            Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }
}
