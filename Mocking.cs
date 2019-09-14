using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mocking : MonoBehaviour
{
    public GameObject mocking;

    public GameObject bubble;
    public GameObject angry;
    public GameObject angry2;

    public Sprite angrysp;

    void OnMouseOver()
    {
        angry.GetComponentInParent<Animator>().enabled = true;
        mocking.GetComponent<Animator>().Play("MockingBigger");
    }

    void OnMouseExit()
    {
        angry.GetComponentInParent<Animator>().enabled = true;
        mocking.GetComponent<Animator>().Play("MockingSmaller");
    }

    void OnMouseDown()
    {
        angry.GetComponentInParent<Animator>().enabled = false;
        angry.GetComponent<SpriteRenderer>().sprite = angrysp;
        angry2.GetComponent<SpriteRenderer>().sprite = angrysp;
        bubble.SetActive(false);
    }
}
