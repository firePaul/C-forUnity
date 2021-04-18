using UnityEngine;

namespace DefaultNamespace.Bonuses
{
    public sealed class BonusFactory : IBonusFactory

    {
        private readonly BonusData _data;

        public BonusFactory(BonusData data)
        {
            _data = data;
        }

        public BonusProvider CreateBonus(BonusType type)
        {
            var bonusProvider = _data.GetBonus(type);
            return Object.Instantiate(bonusProvider);
        }

    }
}