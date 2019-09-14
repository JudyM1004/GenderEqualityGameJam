using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderWithNPC2 : MonoBehaviour
{
    public GameObject angry;
    public GameObject angry2;

    public GameObject bubble;

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            angry.GetComponentInParent<Animator>().enabled = true;
            angry.GetComponentInParent<Animator>().Play("fadeinemoji2");
        }
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            bubble.SetActive(false);

            angry.GetComponentInParent<Animator>().enabled = true;
            angry.GetComponentInParent<Animator>().Play("fadeoutemoji2");
        }
    }
}
