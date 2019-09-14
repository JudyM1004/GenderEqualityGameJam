using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolving : MonoBehaviour
{
    public GameObject resolving;
    public GameObject bubble;
    public GameObject angry;
    public GameObject angry2;
    public GameObject popup2;
    public GameObject mask;

    //public Sprite loveheart;

    public float num = 0;

    void OnMouseOver()
    {
        angry.GetComponentInParent<Animator>().enabled = true;
        resolving.GetComponent<Animator>().Play("ResolvingBigger");
    }

    void OnMouseExit()
    {
        angry.GetComponentInParent<Animator>().enabled = true;
        resolving.GetComponent<Animator>().Play("ResolvingSmaller");
    }

    void OnMouseDown()
    {
        angry.GetComponentInParent<Animator>().enabled = false;
        //angry.GetComponent<SpriteRenderer>().sprite = loveheart;
        //angry2.GetComponent<SpriteRenderer>().sprite = loveheart;
        bubble.SetActive(false);
        num += 1;

        if (num == 1)
        {
            popup2.SetActive(true);
            mask.transform.localScale = new Vector3(80f, 80f, 80f);
        }
    }
}
