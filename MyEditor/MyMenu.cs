using UnityEditor;
using UnityEngine;

namespace DefaultNamespace.MyEditor
{
    public class MyMenu
    {
        [MenuItem("CreateTools/BonusCreate")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(BonusCreateWindow), false, "BonusCreate");
        }
    }
}