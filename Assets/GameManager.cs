using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    public void EndGame()
    {
        Time.timeScale = 0.5f;
        Debug.LogError("De game is over");
    }
}
