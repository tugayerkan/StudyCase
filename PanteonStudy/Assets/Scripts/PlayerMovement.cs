using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 defaultPos;
    public Camera mainCam;
    private Rigidbody _rb;
    public float speedForward = 35f;
    public float speedSideways = 200f;
    public float moveDuration = 0.5f;
    public float gravity = -9.81f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        defaultPos = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EndGame"))
        {
            GameManager.gameState = GameState.Over;
        }
        else if (other.CompareTag("Obstacle"))
        {
            ResetPlayer();
        }
    }
    void Update()
    {
        if (GameManager.gameState == GameState.Playing)
        {

            float xDirection = Input.GetAxis("Horizontal");
            float zDirection = Input.GetAxis("Vertical");
            if (zDirection != 0)
            {
                _rb.velocity = new Vector3(xDirection*speedSideways, gravity * Time.deltaTime, zDirection*speedForward);

            }
            else if (zDirection == 0)
            {
                _rb.velocity = new Vector3(0, gravity * Time.deltaTime, zDirection*speedForward);
            }

        }
        else if (GameManager.gameState == GameState.Over)
        {
            _rb.velocity = new Vector3(0, 0, 0);
        }
    }
    public void ResetPlayer()
    {
        transform.position = defaultPos;
    }
}
