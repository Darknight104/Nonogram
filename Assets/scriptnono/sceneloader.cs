using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneloader : MonoBehaviour
{
    public void LoadSceneByName1()
    {
        SceneManager.LoadScene("noscenes/Level1");
    }
    public void LoadSceneByName2()
    {
        SceneManager.LoadScene("noscenes/Level2");
    } public void LoadSceneByName3()
    {
        SceneManager.LoadScene("noscenes/Level3");
    } public void LoadSceneByName4()
    {
        SceneManager.LoadScene("noscenes/Level4");
    } public void LoadSceneByName5()
    {
        SceneManager.LoadScene("noscenes/Level5");
    } public void LoadSceneByName6()
    {
        SceneManager.LoadScene("noscenes/Level6");
    } public void LoadSceneByName7()
    {
        SceneManager.LoadScene("noscenes/Level7");
    } public void LoadSceneByName8()
    {
        SceneManager.LoadScene("noscenes/Level8");
    }public void LoadSceneByNameselect()
    {
        SceneManager.LoadScene("noscenes/LevelSelect");
    }
    public void LoadSceneByNamehome()
    {
        SceneManager.LoadScene("noscenes/MainMenu");
    }
    public void LoadInBuild()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

}
