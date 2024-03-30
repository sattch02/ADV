using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // 各シーンの状態
    // タイトル画面、メインシーン、イベント、ショップ、スケジュール結果、10ターン後のED
    enum GameState
    {
        Title,
        Main,
        Event,
        Shop,
        Result,
        Ending
    }

    private GameState g_state;

    // Start is called before the first frame update
    public void Start()
    {
        g_state = GameState.Title;
    }

    // Update is called once per frame
    public void Update()
    {
    }

    //　状態の変更
    public void ChangeState()
    {

    }
}
