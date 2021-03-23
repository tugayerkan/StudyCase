using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Rotator : MonoBehaviour
{
    public GameObject horizontaObstacle;
    // Start is called before the first frame update
    void Start()
    {
        horizontaObstacle.transform.DOLocalRotate(horizontaObstacle.transform.localEulerAngles + new Vector3(0, 270, 0), 1f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
    }
}
