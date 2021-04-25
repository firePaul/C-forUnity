using UnityEditor;
using UnityEngine;


namespace DefaultNamespace.MyEditor
{
    public class BonusCreateWindow : EditorWindow

    {
        public static GameObject ObjectInstantiate;
        public string _nameObject = "Bonus";
        public bool _groupEnabled;
        public bool _randomColor = true;
        public Vector3 _position = new Vector3();
        public Vector3 _rotation = new Vector3(0, 0, 0);

        private void OnGUI()
        {
            GUILayout.Label("Базовые настройки", EditorStyles.boldLabel);
            ObjectInstantiate = EditorGUILayout.ObjectField($"Тип бонуса",
                ObjectInstantiate, typeof(GameObject), false) as GameObject;
            _nameObject = EditorGUILayout.TextField("Имя бонуса", _nameObject);
            _position = EditorGUILayout.Vector3Field("Позиция бонуса", _position);
            _groupEnabled = EditorGUILayout.BeginToggleGroup("Дополнительные настройки", _groupEnabled);
            _randomColor = EditorGUILayout.Toggle("Случайный цвет", _randomColor);
            _rotation = EditorGUILayout.Vector3Field($"Поворот бонуса", _rotation);
            var button = GUILayout.Button("Создать бонус");
            if (button)
            {
                if (ObjectInstantiate)
                {
                    GameObject root = new GameObject("Root");
                    Vector3 pos = _position;
                    GameObject temp = Instantiate(ObjectInstantiate, pos, Quaternion.Euler(_rotation));
                    temp.name = _nameObject;
                    temp.transform.parent = root.transform;
                    var tempRenderer = temp.GetComponent<Renderer>();
                    if (tempRenderer && _randomColor)
                    {
                        tempRenderer.material.color = Random.ColorHSV();
                    }
                }
            }
        }
    }
}