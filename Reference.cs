using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public sealed class Reference
    {
        private Canvas _canvas;
        private Button _restartButton;
        private GameObject _endGame;

        public Canvas Canvas
        {
            get
            {
                if (_canvas == null)
                {
                    _canvas = GameObject.FindObjectOfType<Canvas>();
                }

                return _canvas;
            }

        }

        public Button RestartButton
        {
            get
            {
                if (_restartButton == null)
                {
                    var gameObject = Resources.Load<Button>("RestartButton");
                    _restartButton = Object.Instantiate(gameObject, Canvas.transform);
                }
                
                return _restartButton;
            }
        }

        public GameObject EndGame
        {
            get
            {
                if (_endGame == null)
                {
                    var gameObject = Resources.Load<GameObject>("EndGame");
                    _endGame = Object.Instantiate(gameObject, Canvas.transform);
                }
                
                return _endGame;
            }
        }
    }
}