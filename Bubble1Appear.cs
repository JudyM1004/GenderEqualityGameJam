using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble1Appear : MonoBehaviour
{
    public GameObject bubble;
    public GameObject player;

    private Vector3 pos;

    void OnMouseDown()
    {
        bubble.SetActive(true);
        pos = new Vector3(player.transform.position.x - 1.2f, player.transform.position.y + 0.8f, -4);
        bubble.transform.position = pos;
    }
}
