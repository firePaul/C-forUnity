using System;
using System.Collections.Generic;
using System.IO;
using DefaultNamespace.Bonuses;
using UnityEngine;
using Object = UnityEngine.Object;


namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "BonusPosition", menuName = "BonusPosition", order = 0)]
    public class CreateBonus : ScriptableObject
    {
        [Serializable]
        public struct BonusPos
        {
            public GameObject BonusPrefab;
            public float x, y, z;
        }

        public List<BonusPos> bonusPos;
        public List<BonusPos> _bonusPos;
        
        private CreateBonus _bonus;
        
        public CreateBonus Bonus
        {
            get
            {
                if (_bonus == null)
                {
                    _bonus = Load<CreateBonus>("BonusPosition");
                }

                return _bonus;
            }
        }
        private T Load<T>(string resourcesPath) where T : Object => 
            Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }
}