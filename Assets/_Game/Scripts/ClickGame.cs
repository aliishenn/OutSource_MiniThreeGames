using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickGame : MonoBehaviour
{
    public Scrollbar bar;
    public bool isFinish;
    public TMP_Text finishText;
    public GameObject finishPanel;
    public GameObject homePanel;

    public void Restart()
    {
        isFinish = false;
        bar.size = 0.5f;
        finishPanel.SetActive(false);
    }
    public void Back()
    {
        homePanel.SetActive(true);
        Restart();
        gameObject.SetActive(false);


    }
    public void RedClick()
    {
        if (isFinish) return;
        bar.size += 0.04f;
        if (bar.size == 1)
        {
            finishPanel.SetActive(true);
            isFinish = true;
            finishText.text = "Red Win";
        }
    }
    public void GreenClick()
    {
        if (isFinish) return;
        bar.size -= 0.04f;
        if (bar.size == 0)
        {
            finishPanel.SetActive(true);
            isFinish = true;
            finishText.text = "Green Win";
        }
    }
}
