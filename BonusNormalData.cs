using UnityEngine;

namespace DefaultNamespace
{   
    [System.Serializable]
    public class BonusNormalData
    {
        public float[] position;

        public BonusNormalData(Bonus bonus)
        {
            position = new float[3];
            position[0] = bonus.transform.position.x;
            position[1] = bonus.transform.position.y;
            position[2] = bonus.transform.position.z;
        }
    }
}