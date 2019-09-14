using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silence : MonoBehaviour
{
    public GameObject silence;
    public GameObject bubble;
    public GameObject girl;
    public GameObject bum;
    public GameObject evil;

    public Sprite girlsp;
    public Sprite bumsp;
    public Sprite evilsp;

    void OnMouseOver()
    {
        girl.GetComponentInParent<Animator>().enabled = true;
        silence.GetComponent<Animator>().Play("SilenceBigger");
    }

    void OnMouseExit()
    {
        girl.GetComponentInParent<Animator>().enabled = true;
        silence.GetComponent<Animator>().Play("SilenceSmaller");
    }

    void OnMouseDown()
    {
        girl.GetComponentInParent<Animator>().enabled = false;
        girl.GetComponent<SpriteRenderer>().sprite = girlsp;
        bum.GetComponent<SpriteRenderer>().sprite = bumsp;
        evil.GetComponent<SpriteRenderer>().sprite = evilsp;
        bubble.SetActive(false);
    }
}
