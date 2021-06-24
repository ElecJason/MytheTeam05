using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginAnimationEnd : MonoBehaviour
{
     if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("stateEnd"))
 	{
    		debug.log{"ended"};
 	}
}
