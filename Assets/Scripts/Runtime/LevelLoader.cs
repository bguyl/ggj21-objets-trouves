namespace Guyl.ObjetsTrouves
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Cysharp.Threading.Tasks;
    using TMPro;
    using UnityAtoms.BaseAtoms;
    using UnityAtoms.SceneMgmt;
    using UnityEngine;
    using UnityEngine.InputSystem;
    using UnityEngine.SceneManagement;
    using UnityEngine.UI;
    using Void = UnityAtoms.Void;

    public class LevelLoader : MonoBehaviour
    {
        [SerializeField] private List<SceneFieldReference> _levels;
        [SerializeField] private PlayerInputManager _playerInputManager;
        [SerializeField] private VoidEvent _onVictory;
        [SerializeField] private Image _fader;
        [SerializeField] private FloatReference _fadeAnimationTime = new FloatReference(0.5f);
        [SerializeField] private TMP_Text _found;

        private int _currentLevel = 0;
        private LoadSceneParameters _scenesParameters;
        private Scene loadedScene;
        
        private async void Start()
        {
            _scenesParameters = new LoadSceneParameters(LoadSceneMode.Additive);
            loadedScene = SceneManager.LoadScene(_levels[_currentLevel].Value.BuildIndex, _scenesParameters);

            while (!loadedScene.isLoaded)
            {
                await UniTask.Yield();
            }

            float alpha = 1f;
            float time = 0f;

            while (alpha > 0f)
            {
                alpha = Mathf.Lerp(1f, 0f, time / _fadeAnimationTime);
                await UniTask.Yield(PlayerLoopTiming.FixedUpdate);
                time += Time.fixedDeltaTime;
                _fader.color = new Color(_fader.color.r, _fader.color.g, _fader.color.b, alpha);
            }

            LevelProxy level = loadedScene.GetRootGameObjects()[0].GetComponent<LevelProxy>();

            if (level != null)
            {
                _playerInputManager.GetComponent<PlayerSetup>().PlayerSpawners = level.PlayerSpawners;
                _playerInputManager.gameObject.SetActive(true);
            }
            
            _onVictory.Register(OnVictory);
        }

        private async void OnVictory(Void obj)
        {
            _currentLevel++;

            float alpha = 0f;
            float time = 0f;

            while (alpha < 1f)
            {
                alpha = Mathf.Lerp(0f, 1f, time / _fadeAnimationTime);
                await UniTask.Yield(PlayerLoopTiming.FixedUpdate);
                time += Time.fixedDeltaTime;
                _fader.color = new Color(_fader.color.r, _fader.color.g, _fader.color.b, alpha);
            }
            
            AsyncOperation unloadHandler = SceneManager.UnloadSceneAsync(loadedScene);
            while (!unloadHandler.isDone)
            {
                await UniTask.Yield();
            }
            
            _found.gameObject.SetActive(true);

            if (_currentLevel < _levels.Count)
            {
                loadedScene = SceneManager.LoadScene(_levels[_currentLevel].Value.BuildIndex, _scenesParameters);
                
                while (!loadedScene.isLoaded)
                {
                    await Task.Yield();
                }
                
                await UniTask.Delay(TimeSpan.FromSeconds(2));

                alpha = 1f;
                time = 0f;
                _found.gameObject.SetActive(false);
                
                while (alpha > 0f)
                {
                    alpha = Mathf.Lerp(1f, 0f, time / _fadeAnimationTime);
                    await UniTask.Yield(PlayerLoopTiming.FixedUpdate);
                    time += Time.fixedDeltaTime;
                    _fader.color = new Color(_fader.color.r, _fader.color.g, _fader.color.b, alpha);
                }

                LevelProxy level = loadedScene.GetRootGameObjects()[0].GetComponent<LevelProxy>();

                if (level != null)
                {
                    List<PlayerInput> list = _playerInputManager.GetComponent<PlayerSetup>().InstanciatedPlayers;

                    for (int i = 0; i < list.Count; i++)
                    {
                        PlayerInput player = list[i];
                        player.GetComponent<VictoryChecker>().Reset();
                        player.transform.position = level.PlayerSpawners[i].position;
                    }
                }
            }
            else
            {
                SceneManager.LoadScene("ThanksScene");
            }
        }
    }
}