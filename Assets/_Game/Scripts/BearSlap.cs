using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BearSlap : MonoBehaviour
{
    public int healt;
    public bool isFinish = true;
    public GameObject finishPanel;
    public GameObject uiPanel;
    public GameObject homePanel;

    public void Restart()
    {
        healt = 100;
        isFinish = true;
        finishPanel.SetActive(false);
    }
    public void Back()
    {
        homePanel.SetActive(true);
        Restart();
        uiPanel.SetActive(false);
        gameObject.SetActive(false);
    }
    public void RightClick()
    {
        if (!isFinish) return;
        transform.DOKill();
        healt -= Random.Range(2, 5);

        if (healt <= 0)
        {
            isFinish = false;
            finishPanel.SetActive(true);
        }
        transform.DORotateQuaternion(Quaternion.Euler(-96.592f, 24.638f, 0), 0.5f).OnComplete(() =>
        {
            transform.DORotate(new Vector3(-96.592f, 0, 0), 0.2f);
        });
    }

    public void LeftClick()
    {
        if (!isFinish) return;
        transform.DOKill();
        healt -= Random.Range(2, 5);
        if (healt <= 0)
        {
            isFinish = false;
            finishPanel.SetActive(true);
        }
        transform.DORotate(new Vector3(-96.592f, -24.638f, 0), 0.5f).OnComplete(() =>
        {
            transform.DORotateQuaternion(Quaternion.Euler(-96.592f, 0, 0), 0.2f);

        });
    }
}
