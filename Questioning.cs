using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questioning : MonoBehaviour
{
    public GameObject questioning;
    public GameObject bubble;
    public GameObject girl;
    public GameObject bum;
    public GameObject evil;
    public GameObject popup1;
    public GameObject mask;

    public Sprite question;

    public float num = 0;

    void OnMouseOver()
    {
        girl.GetComponentInParent<Animator>().enabled = true;
        questioning.GetComponent<Animator>().Play("bigger");
    }

    void OnMouseExit()
    {
        girl.GetComponentInParent<Animator>().enabled = true;
        questioning.GetComponent<Animator>().Play("smaller");
    }

    void OnMouseDown()
    {
        girl.GetComponentInParent<Animator>().enabled = false;
        girl.GetComponent<SpriteRenderer>().sprite = question;
        bum.GetComponent<SpriteRenderer>().sprite = question;
        evil.GetComponent<SpriteRenderer>().sprite = question;
        bubble.SetActive(false);
        num += 1;

        if(num == 1)
        {
            popup1.SetActive(true);
            mask.transform.localScale = new Vector3(50f, 50f, 50f);
        }
    }

}
