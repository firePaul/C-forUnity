using UnityEngine;

namespace DefaultNamespace.Bonuses
{
    public class BonusProvider:MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private Transform _transform;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _transform = transform;
        }
    }
}