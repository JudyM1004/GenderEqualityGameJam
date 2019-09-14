using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1Options : MonoBehaviour
{
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject player;

    private Vector3 pos;

    void OnMouseDown()
    {
        option1.SetActive(true);
        pos = new Vector3(player.transform.position.x - 1, player.transform.position.y + 1, -1);
        option1.transform.position = pos;

        option2.SetActive(true);
        pos = new Vector3(player.transform.position.x, player.transform.position.y + 1, -1);
        option2.transform.position = pos;

        option3.SetActive(true);
        pos = new Vector3(player.transform.position.x + 1, player.transform.position.y + 1, -1);
        option3.transform.position = pos;
    }
}
