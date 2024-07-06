using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour
{
    public void Inst()
    {
        Debug.Log("clicked1");
        SceneManager.LoadScene("MainMenu");

    }
}
