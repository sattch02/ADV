using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // ��{�I�ȃL�����X�e�[�^�X
    // �^�[�����A�������A�U���A�h��A�f�����A��́A���x���A�o���l
    [SerializeField] private Dictionary<string, int> charaStatusList = new Dictionary<string, int>();

    // �����A�C�e���ꗗ
    // key�F�A�C�e�����Avalue�F������
    [SerializeField] private Dictionary<string, int> itemList = new Dictionary<string, int>();

    // ���X�̃X�e�[�^�X�ꗗ
    // key�F�X�e�[�^�X���Avalue�F���l
    [SerializeField] private Dictionary<string, int> shopStatusList = new Dictionary<string, int>();

    public void Awake()
    {
        // �����Ńv���C���f�[�^�̃��[�h�B�f�[�^�����������珉��������B

        Init();
    }
    
    // �v���C���[�f�[�^�̏�����
    public void Init()
    {

    }

    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    // �����Ńv���C���f�[�^�̃��[�h
    public void playerDataLoad()
    {

    }
}
