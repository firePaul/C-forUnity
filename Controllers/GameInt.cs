using DefaultNamespace.Bonuses;

namespace DefaultNamespace
{
    internal sealed class GameInt
    {
        public GameInt(BonusData data)
        {
            var bonusFactory = new BonusFactory(data.Bonus);
            var bonusInt = new BonusInt(bonusFactory);
        }
    }
}