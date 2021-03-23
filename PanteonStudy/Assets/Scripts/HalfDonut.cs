using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class HalfDonut : MonoBehaviour
{
    public GameObject HalfDonutObstacle;
    void Start()
    {
        HalfDonutObstacle.transform.DOLocalRotate(HalfDonutObstacle.transform.localEulerAngles + new Vector3(270, 0, 0), 2f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
    }

}
