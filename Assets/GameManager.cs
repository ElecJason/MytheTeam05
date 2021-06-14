using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
    public void EndGame()
    {
        SceneManager.LoadScene(3);
        Cursor.lockState = CursorLockMode.Confined;
        Debug.LogError("De game is over");
    }
}
