using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // 基本的なキャラステータス
    // ターン数、所持金、攻撃、防御、素早さ、戦力、レベル、経験値
    [SerializeField] private Dictionary<string, int> charaStatusList = new Dictionary<string, int>();

    // 所持アイテム一覧
    // key：アイテム名、value：所持数
    [SerializeField] private Dictionary<string, int> itemList = new Dictionary<string, int>();

    // お店のステータス一覧
    // key：ステータス名、value：数値
    [SerializeField] private Dictionary<string, int> shopStatusList = new Dictionary<string, int>();

    public void Awake()
    {
        // ここでプレイヤデータのロード。データが無かったら初期化する。

        Init();
    }
    
    // プレイヤーデータの初期化
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

    // ここでプレイヤデータのロード
    public void playerDataLoad()
    {

    }
}
