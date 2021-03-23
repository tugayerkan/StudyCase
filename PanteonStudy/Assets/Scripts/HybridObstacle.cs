using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class HybridObstacle : MonoBehaviour
{
    public GameObject hybridObstacle;
    public float moveType;
    void Start()
    {
        hybridObstacle.transform.DOMoveY(moveType, 2f).SetEase(Ease.InSine).SetLoops(-1, LoopType.Yoyo);
    }
}
