using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MainCamera : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private Vector3 offset;
    public Camera cam;

    void Update()
    {
        transform.position = player.position + offset;
        if (GameManager.gameState == GameState.Over)
        {
            cam.transform.DOLocalMove(new Vector3(0f, 2.26f, 161.76f), 1);
            cam.transform.DORotate(new Vector3(-4.86f, 0, 0), 1f);

        }
    }
}
