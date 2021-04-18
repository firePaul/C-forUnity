using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DefaultNamespace.Bonuses;
using UnityEngine;

namespace DefaultNamespace
{
    public static class NormalSaveSystem
    {
        public static void SaveBonus(Bonus bonus)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/bonus.hehe";
            FileStream stream = new FileStream(path, FileMode.Create);

            BonusNormalData data = new BonusNormalData(bonus);
            
            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static BonusNormalData LoadBonus()
        {
            string path = Application.persistentDataPath + "/bonus.hehe";
            if (File.Exists((path)))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                BonusNormalData data = formatter.Deserialize((stream)) as BonusNormalData;
                stream.Close();
                return data;

            }
            else
            {  Debug.LogError("save file not found in" + path);
                return null;
            }

        }
    }
}