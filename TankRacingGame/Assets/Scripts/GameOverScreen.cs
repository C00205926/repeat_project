using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject GameOverWin;
    public GameObject GameOverLose;

    public void GetMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
