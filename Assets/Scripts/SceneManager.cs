using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // ���
    // �^�C�g����ʁA���C���V�[���A�C�x���g�A�V���b�v�A�X�P�W���[�����ʁA10�^�[�����ED
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

    //�@��Ԃ̕ύX
    public void ChangeState()
    {

    }
}
