using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{ 
    public void EndGame()
    {
        SceneManager.LoadScene(2);
        Cursor.lockState = CursorLockMode.Confined;
        Debug.LogError("De game is over");
    }

    public void WinGame()
    {
        SceneManager.LoadScene(3);
        Cursor.lockState = CursorLockMode.Confined;
        Debug.LogError("Ik won de game");
    }
}
