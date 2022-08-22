using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class FlipCoin : MonoBehaviour
{
    private bool _isRun;
    private Sequence _rotationSequence;
    public void Flip()
    {
        if (_isRun)return;
        _isRun = true;
        _rotationSequence = DOTween.Sequence();
        _rotationSequence.Append(transform.DOLocalRotate(new Vector3(360, 0, 0), 0.5f, RotateMode.FastBeyond360)
            .SetRelative(true)
            .SetEase(Ease.Linear)).SetLoops(-1);
        

        transform.DOLocalMoveZ(3.5f, 1f).OnComplete(() =>
        {
            transform.DOLocalMoveZ(5f, 1).OnComplete(() =>
            {
                _rotationSequence.Kill();
                _isRun = false;
                var _isFlip = Random.Range(0, 2);
                if (_isFlip>0)
                {
                    transform.eulerAngles = new Vector3(0, 180, 0);
                }
                else
                {
                    transform.eulerAngles = Vector3.zero;
                }
                
                //transform.eulerAngles = Vector3.zero;
            });
        });
    }

    private void OnMouseDown()
    {
        Flip();
    }
}
