using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
    public void EndGame()
    {
        Time.timeScale = 0.5f;
        SceneManager.LoadScene(2);
        Debug.LogError("De game is over");
    }
}
