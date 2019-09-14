using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judging : MonoBehaviour
{
    public GameObject judging;

    public GameObject bubble;
    public GameObject angry;
    public GameObject angry2;

    public Sprite angry2sp;

    void OnMouseOver()
    {
        angry.GetComponentInParent<Animator>().enabled = true;
        judging.GetComponent<Animator>().Play("JudgingBigger");
    }

    void OnMouseExit()
    {
        angry.GetComponentInParent<Animator>().enabled = true;
        judging.GetComponent<Animator>().Play("JudgingSmaller");
    }

    void OnMouseDown()
    {
        angry.GetComponentInParent<Animator>().enabled = false;
        angry.GetComponent<SpriteRenderer>().sprite = angry2sp;
        angry2.GetComponent<SpriteRenderer>().sprite = angry2sp;
        bubble.SetActive(false);
    }
}
