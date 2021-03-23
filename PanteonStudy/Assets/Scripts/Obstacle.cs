using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Obstacle : MonoBehaviour
{
    public GameObject horizontaObstacle;
    void Start()
    {
        horizontaObstacle.transform.DOLocalRotate(horizontaObstacle.transform.localEulerAngles + new Vector3(0, 270, 0), 1f).SetEase(Ease.InOutQuad).SetLoops(-1, LoopType.Incremental);
    }

}
