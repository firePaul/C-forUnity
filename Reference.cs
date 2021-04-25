using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public sealed class Reference
    {
        private Canvas _canvas;
        private Button _restartButton;
        private GameObject _endGame;
        private HeroPlayer _heroPlayer;
        private Camera _mainCamera;

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
        public Camera MainCamera
        {
            get
            {
                if (_mainCamera == null)
                {
                    _mainCamera = Camera.main;
                }
                return _mainCamera;
            }
        }

        public HeroPlayer HeroPlayer
        {
            get
            {
                if (_heroPlayer == null)
                {
                    var gameObject = Resources.Load<HeroPlayer>("Player");
                    _heroPlayer = Object.Instantiate(gameObject);
                }

                return _heroPlayer;
            }
        }
    }
}