using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }

       /*public void Inst()
    {
        SceneManager.LoadScene(3);
    }*/
}
