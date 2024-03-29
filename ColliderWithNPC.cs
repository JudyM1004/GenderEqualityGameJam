﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderWithNPC : MonoBehaviour
{
    public GameObject Girl;
    public GameObject Bum;
    public GameObject Evil;
    public GameObject bubble;

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            Girl.GetComponentInParent<Animator>().enabled = true;
            Girl.GetComponentInParent<Animator>().Play("fadeinemoji");
        }
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            bubble.SetActive(false);

            Girl.GetComponentInParent<Animator>().enabled = true;
            Girl.GetComponentInParent<Animator>().Play("fadeoutemoji");
        }
    }
}
