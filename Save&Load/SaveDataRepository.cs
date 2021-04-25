using Interface;
using System.IO;
using DefaultNamespace.Model;
using UnityEngine;

namespace DefaultNamespace
{
    public sealed class SaveDataRepository : ISaveDataRepository
    {
        private readonly IData<SavedData> _data;

        private const string _folderName = "DataSave";
        private const string _fileName = "data.xml";
        private readonly string _path;

        public SaveDataRepository()
        {
            _data = new XMLData();
            _path = Path.Combine(Application.dataPath, _folderName);

        }

        public void Save(BonusBase bonus)
        {
            if (!Directory.Exists(Path.Combine(_path)))
            {
                Directory.CreateDirectory(_path);
            }

            var saveBonus = new SavedData
            {
                Position = bonus.transform.position,
                Name = "Bonus",
                IsEnabled = true
            };

            Debug.Log("<color=green>Save</color>");
            _data.Save(saveBonus, Path.Combine(_path, _fileName));
        }

        public void Load(BonusBase bonus)
        {
            var file = Path.Combine(_path, _fileName);
            if (!File.Exists(file)) return;
            var newPlayer = _data.Load(file);
            bonus.transform.position = newPlayer.Position;
            bonus.name = newPlayer.Name;
            bonus.gameObject.SetActive(newPlayer.IsEnabled);

            Debug.Log(newPlayer);
        }
    }
}