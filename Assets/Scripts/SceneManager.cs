﻿using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // 各シーンの状態
    // タイトル画面、メインシーン、イベント、ショップ、スケジュール結果、10ターン後のED
    public enum GameState
    {
        Title,
        Main,
        Event,
        Shop,
        Result,
        Ending
    }

    [SerializeField] private GameState g_state;

    // Start is called before the first frame update
    public void Start()
    {
        g_state = GameState.Title;
    }

    // Update is called once per frame
    public void Update()
    {
        switch(g_state)
        {
            case GameState.Title:
                break;
            case GameState.Main:
                Debug.Log("MainScene------");
                break;
            case GameState.Event:
                break;
            case GameState.Shop:
                break;
            case GameState.Result:
                break;
            case GameState.Ending:
                break;
        }
    }

    // 状態の変更
    public void ChangeState(int state)
    {
        switch(state)
        {
            case 1:
                g_state = GameState.Main;
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
    }
}
