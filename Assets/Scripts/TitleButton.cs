using MessagePack.Resolvers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleButton : MonoBehaviour
{
    private SceneController sceneController;

    // Start is called before the first frame update
    public void Start()
    {
        sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
    }

    // Update is called once per frame
    public void Update()
    {   
    }

    public void OnClickStart()
    {
        sceneController.ChangeState(SceneController.GameState.Main);
    }

    public void OnClickLoad()
    {

    }
}
