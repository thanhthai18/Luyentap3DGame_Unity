using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlyingObjectController : MonoBehaviour
{
    public Vector3 scaleUp;
    public Vector3 scaleDown;
    // Start is called before the first frame update
    void Start()
    {
        //var tween = transform.DOScale(scaleUp, 2f).OnComplete(() => { transform.DOScale(scaleDown, 2f); });
        //tween.SetLoops = -1;

        Sequence scaleSeq = DOTween.Sequence();
        scaleSeq.Append(transform.DOScale(scaleUp, 2f));
        scaleSeq.Append(transform.DOScale(scaleDown, 2f));
        scaleSeq.SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
