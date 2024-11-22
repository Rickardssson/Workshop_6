using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public class JumpTest : MonoBehaviour
{
    Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        playerAnimator.SetBool("jumping", false);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            playerAnimator.SetBool("jumping", true);
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.flipX = false;
        }
        
        if (Input.GetKeyUp("w"))
        {
            playerAnimator.SetBool("running", false);
        }
    }
}
