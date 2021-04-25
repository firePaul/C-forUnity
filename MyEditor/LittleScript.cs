using UnityEngine;

namespace DefaultNamespace.MyEditor
{
    public class LittleScript : MonoBehaviour

    {

        public Vector3 objposition = new Vector3(0, 0, 0);
        public Vector3 objrotataion = new Vector3(0, 0, 0);
        public Vector3 objscale = new Vector3(1, 1, 1);
        public GameObject obj;

        private void Start()
        {
            CreateObj();
        }

        public void CreateObj()
        {
            var o = Instantiate(obj, objposition, Quaternion.Euler(objrotataion));
            o.transform.localScale = objscale;
        }

        public void AddComponent()
        {
            obj.AddComponent<Rigidbody>();
            obj.AddComponent<MeshRenderer>();
            obj.AddComponent<MeshCollider>();
        }

        public void RemoveComponent()
        {
            DestroyImmediate(obj.GetComponent<Rigidbody>(),true);
            DestroyImmediate(obj.GetComponent<MeshRenderer>(),true);
            DestroyImmediate(obj.GetComponent<MeshCollider>(),true);
        }
    }
}   
