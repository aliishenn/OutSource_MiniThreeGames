using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPanelController : MonoBehaviour
{
    [SerializeField] private GameObject flip;
    [SerializeField] private GameObject flipObject;
    public GameObject bear;
    public GameObject bearObject;
    public GameObject click;

    public void OpenFlip()
    {
        gameObject.SetActive(false);
        flip.SetActive(true);
        flipObject.SetActive(true);
    }
    public void OpenBear()
    {
        gameObject.SetActive(false);

        bear.SetActive(true);
        bearObject.SetActive(true);
    }
    public void OpenClick()
    {
        gameObject.SetActive(false);

        click.SetActive(true);
    }
}
