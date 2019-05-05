using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewManager : MonoBehaviour
{
    [SerializeField] private Text _scopeGame;
    [SerializeField] private Slider _timer;
    [SerializeField] private GameObject _panelGameOver;
    [SerializeField] private Text _scopeGameEnd;
    [SerializeField] private Text _maxScope;

    public static ViewManager vm;

    void Update()
    {
        if (!GameManager.gm.IsEnd)
        {
            _scopeGame.text = "Scope:" + GameManager.gm.Scope;
            _timer.value = GameManager.gm.Timer;
        }
        if (GameManager.gm.IsPause)
        {
            _scopeGame.text = "Pause";
        }
    }

    void Awake()
    {
        if (vm == null)
        {
            vm = this;
        }
    }

    void GameOver()
    {
        _panelGameOver.SetActive(true);
        _scopeGame.text = "";
        _scopeGameEnd.text = "Scope:" + GameManager.gm.Scope;
        _maxScope.text = "Max Scope:" + PlayerPrefs.GetInt("maxScope", 0);
    }
}
