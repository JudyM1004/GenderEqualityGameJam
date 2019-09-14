using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Violence : MonoBehaviour
{
    public GameObject violence;

    public GameObject bubble;
    public GameObject girl;
    public GameObject bum;
    public GameObject evil;

    public Sprite angry;

    void OnMouseOver()
    {
        girl.GetComponentInParent<Animator>().enabled = true;
        violence.GetComponent<Animator>().Play("ViolenceBigger");
    }

    void OnMouseExit()
    {
        girl.GetComponentInParent<Animator>().enabled = true;
        violence.GetComponent<Animator>().Play("ViolenceSmaller");
    }

    void OnMouseDown()
    {
        girl.GetComponentInParent<Animator>().enabled = false;
        girl.GetComponent<SpriteRenderer>().sprite = angry;
        bum.GetComponent<SpriteRenderer>().sprite = angry;
        evil.GetComponent<SpriteRenderer>().sprite = angry;
        bubble.SetActive(false);
    }
}
