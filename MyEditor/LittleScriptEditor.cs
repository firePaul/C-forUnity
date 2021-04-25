using UnityEditor;
using UnityEngine;


namespace DefaultNamespace.MyEditor
{
    [CustomEditor(typeof(LittleScript))]
    public class LittleScriptEditor : UnityEditor.Editor

    {
        private bool _button;

        public override void OnInspectorGUI()
        {
            LittleScript littleScript = (LittleScript) target;
            littleScript.objposition = EditorGUILayout.Vector3Field("Позиция", littleScript.objposition);
            littleScript.objrotataion = EditorGUILayout.Vector3Field("Поворот", littleScript.objrotataion);
            littleScript.objscale = EditorGUILayout.Vector3Field("Размер", littleScript.objscale);

            littleScript.obj = EditorGUILayout.ObjectField("Объект который хотим",
                littleScript.obj, typeof(GameObject), false) as GameObject;

            var isPressButton = GUILayout.Button("Создать объект",
                EditorStyles.miniButtonLeft);

            _button = GUILayout.Toggle(_button, "Компоненты");

            if (isPressButton)
            {
                littleScript.CreateObj();
                _button = true;
            }

            if (_button)
            {
                var isPressAddButton = GUILayout.Button("Add Component",
                    EditorStyles.miniButtonLeft);
                var isPressRemoveButton = GUILayout.Button("Remove Component",
                    EditorStyles.miniButtonLeft);
                if (isPressAddButton)
                {
                    littleScript.AddComponent();
                }

                if (isPressRemoveButton)
                {
                    littleScript.RemoveComponent();
                }
            }
        }
    }
}
