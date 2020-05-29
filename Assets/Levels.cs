using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLvl1()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadLvl2()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadLvl3()
    {
        SceneManager.LoadScene(7);
    }

    public void LoadLvl4()
    {
        SceneManager.LoadScene(8);
    }

    public void LoadLvl5()
    {
        SceneManager.LoadScene(9);
    }

    public void LoadLvl6()
    {
        SceneManager.LoadScene(10);
    }

    public void LoadBomb()
    {
        SceneManager.LoadScene(11);
    }

    public void LoadRun()
    {
        SceneManager.LoadScene(12);
    }

    public void LoadCongrats()
    {
        SceneManager.LoadScene(13);
    }

    public void LoadStory()
    {
        SceneManager.LoadScene(14);
    }

    public void LoadStart()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene(2);
    }
}
