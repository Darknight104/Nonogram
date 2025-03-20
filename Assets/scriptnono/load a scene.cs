using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadscene: MonoBehaviour
{
    public void LoadSceneByName1()
    {
        SceneManager.LoadScene("noscenes/Level1");
    }
    public void LoadScenebyName2()
    {
        SceneManager.LoadScene("noscenes/Level2");
    }public void LoadScenebyName3()
    {
        SceneManager.LoadScene("noscenes/level3");
    }public void LoadScenebyName4()
    {
        SceneManager.LoadScene("noscenes/Level4");
    }public void LoadScenebyName5()
    {
        SceneManager.LoadScene("noscenes/Level5");
    }public void LoadScenebyName6()
    {
        SceneManager.LoadScene("noscenes/Level6");
    }public void LoadScenebyName7()
    {
        SceneManager.LoadScene("noscenes/Level7");
    }public void LoadScenebyName8()
    {
        SceneManager.LoadScene("noscenes/Level8");
    } 
    public void Loadmainmenu()
    {
        SceneManager.LoadScene("noscenes/MainMenu");
    }
    public void LoadInBuild()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
