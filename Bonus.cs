using UnityEngine;

namespace DefaultNamespace
{
    public class Bonus:MonoBehaviour

    {   

        private readonly KeyCode _saveBonus = KeyCode.C;
        private readonly KeyCode _loadBonus = KeyCode.V;
        public void FixedUpdate()
        {
            if (Input.GetKeyDown(_saveBonus))
            {
                NormalSaveSystem.SaveBonus(this);
            }
            if (Input.GetKeyDown(_loadBonus))
            {
                BonusNormalData data = NormalSaveSystem.LoadBonus();

                Vector3 position;
                position.x = data.position[0];
                position.y = data.position[1];
                position.z = data.position[2];
                transform.position = position;
            }
        }
    }
}