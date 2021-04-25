using DefaultNamespace.Model;
using Interface;
using UnityEngine;

namespace DefaultNamespace
{
    public class BonusInput : MonoBehaviour
    {
        private readonly BonusBase _bonusBase;
        private readonly ISaveDataRepository _saveDataRepository;
        private readonly KeyCode _saveBonus = KeyCode.F5;
        private readonly KeyCode _loadBonus = KeyCode.F6;


        public BonusInput(BonusBase bonus)
        {
            _bonusBase = bonus;
            _saveDataRepository = new SaveDataRepository();
        }

        public void FixedUpdate()
        {

            if (Input.GetKeyDown(_saveBonus))
            {
                _saveDataRepository.Save(_bonusBase);
            }
            if (Input.GetKeyDown(_loadBonus))
            {
                _saveDataRepository.Load(_bonusBase);
            }
        }
    }
}