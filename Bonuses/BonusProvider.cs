using UnityEngine;

namespace DefaultNamespace.Bonuses
{
    public class BonusProvider:MonoBehaviour
    {
        private Transform _transform;

        private void Start()
        {
            _transform = transform;
        }
    }
}