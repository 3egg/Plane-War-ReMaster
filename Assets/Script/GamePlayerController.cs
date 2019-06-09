using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayerController : MonoBehaviour
{
    private void Awake()
    {
        int length = FindObjectsOfType<GamePlayerController>().Length;
        if (length > 1)
        {
            DestroyObject(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void LoadGamePlayScene()
    {
        SceneManager.LoadScene(1);
    }
}