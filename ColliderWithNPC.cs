using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderWithNPC : MonoBehaviour
{
    public GameObject Emoji;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            Emoji.SetActive(true);
        }
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            option1.SetActive(false);
            option2.SetActive(false);
            option3.SetActive(false);
            Emoji.SetActive(false);
        }
    }
}
