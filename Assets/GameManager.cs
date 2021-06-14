using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void WinGame()
    {
        SceneManager.LoadScene(3);
        Cursor.lockState = CursorLockMode.Confined;
        Debug.LogError("De game is over, you won");
    }

    public void LoseGame()
    {
        SceneManager.LoadScene(2);
        Cursor.lockState = CursorLockMode.Confined;
        Debug.LogError("De game is over, you lost");
    }
}
