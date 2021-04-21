using DefaultNamespace.Model;

namespace Interface
{
    public interface ISaveDataRepository
    {
        void Save(BonusBase bonus);
        void Load(BonusBase bonus);
    }
}