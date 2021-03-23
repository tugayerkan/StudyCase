using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class VerticalRotation : MonoBehaviour
{
    public GameObject verticalRotationObstacle;
    // Start is called before the first frame update
    void Start()
    {
        verticalRotationObstacle.transform.DOLocalRotate(verticalRotationObstacle.transform.localEulerAngles + new Vector3(0, 0, 270), 2f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
    }
}
