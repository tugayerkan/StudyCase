using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{

    public Rigidbody rb;
    private Vector2 lastPos;
    private float speedMultiplier = 200f;
    public float gravity = -9.81f;
    public bool isRunningForward = false;
    public bool isRunningBackward = false;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    lastPos = touch.position;
                    break;
                case TouchPhase.Moved:
                    Vector3 newVelocity = Vector3.zero;
                    //Left
                    if (lastPos.x > touch.position.x)
                    {
                        newVelocity += new Vector3(-1, gravity*Time.deltaTime, 2) * speedMultiplier * Time.deltaTime;

                    }
                    //Right
                    else if (lastPos.x < touch.position.x)
                    {
                        newVelocity += new Vector3(1, 0, 2) * speedMultiplier * Time.deltaTime;

                    }
                    //Backward
                    if (lastPos.y > touch.position.y)
                    {
                        newVelocity += Vector3.back * speedMultiplier * Time.deltaTime;
                        isRunningBackward = true;

                    }
                    //Forward
                    else if (lastPos.y < touch.position.y)
                    {
                        isRunningForward = true;
                        newVelocity += Vector3.forward * speedMultiplier * Time.deltaTime;
                    }
                    rb.velocity = newVelocity;
                    break;
                case TouchPhase.Stationary:
                    break;
                case TouchPhase.Ended:
                    isRunningForward = false;
                    isRunningBackward = false;
                    rb.velocity = Vector3.zero;
                    break;
                case TouchPhase.Canceled:
                    rb.velocity = Vector3.zero;
                    break;
                default:
                    rb.velocity = Vector3.zero;
                    break;
            }

        }
    }
}
