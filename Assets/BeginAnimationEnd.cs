using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginAnimationEnd : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(CutSceneTimer());
    }

    IEnumerator CutSceneTimer()
    {
        yield return new WaitForSeconds(20);
        Destroy(this.gameObject);
    }
}
