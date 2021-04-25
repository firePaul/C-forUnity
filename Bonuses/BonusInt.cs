namespace DefaultNamespace.Bonuses
 
{
    public class BonusInt
    {
        private readonly IBonusFactory _bonusFactory;


        public BonusInt(IBonusFactory bonusFactory)
        {
            _bonusFactory = bonusFactory;
            
            var bonus = _bonusFactory.CreateBonus(BonusType.AmmoBonus);
            
        }
    }

}
