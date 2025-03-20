using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadselect : MonoBehaviour
{
    public void LoadSceneByName1()
    {
        SceneManager.LoadScene("noscenes/LevelSelect");
    }
    public void exit()
    {
        Application.Quit();
    }
}
