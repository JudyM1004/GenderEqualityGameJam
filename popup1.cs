using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup1 : MonoBehaviour
{
    public float time;
    public GameObject popup;

    // Start is called before the first frame update
    void Start()
    {
        time = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        if(time <= 300f && time > 0)
        {
            time--;
        }

        if(time == 0)
        {
            popup.SetActive(false);
        }

        //Debug.Log(time);
    }
}
