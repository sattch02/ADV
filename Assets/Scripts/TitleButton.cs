using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleButton : MonoBehaviour
{
    private SceneManager sceneManager;

    // Start is called before the first frame update
    public void Start()
    {
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();
    }

    // Update is called once per frame
    public void Update()
    {   
    }

    public void OnClickStart()
    {

        sceneManager.ChangeState(1);
    }

    public void OnClickLoad()
    {

    }
}
