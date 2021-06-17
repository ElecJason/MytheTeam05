﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handAnimation : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetInteger("hand_state", 1);

        }
        else if(Input.GetKeyUp(KeyCode.W))
        {
            anim.SetInteger("hand_state", 0);
        }
    }
}
