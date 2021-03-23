using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    public TouchMove touch;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {

        bool forwardPressed = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || touch.isRunningForward;
        bool backwardPressed = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) || touch.isRunningBackward;

        if (forwardPressed)
        {
            animator.SetBool("isRunning", true);
        }
        if (!forwardPressed)
        {
            animator.SetBool("isRunning", false);
        }
        if (backwardPressed)
        {
            animator.SetBool("isBackward", true);
        }
        if (!backwardPressed)
        {
            animator.SetBool("isBackward", false);
        }
        if (GameManager.gameState == GameState.Over)
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isBackward", false);
        }
    }
}
