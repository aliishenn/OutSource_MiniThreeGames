using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipPanel : MonoBehaviour
{
    public GameObject flip;
    public GameObject flipObject;
    public GameObject mainPanel;

    public void Back()
    {
        mainPanel.SetActive(true);
        flipObject.SetActive(false);
        flip.SetActive(false);
    }
}
