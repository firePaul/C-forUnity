namespace DefaultNamespace.Bonuses
{
    public interface IBonusFactory
    {
        BonusProvider CreateBonus(BonusType type);
    }
}