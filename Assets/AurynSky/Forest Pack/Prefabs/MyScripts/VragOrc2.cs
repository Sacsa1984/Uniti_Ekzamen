using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VragOrc2 : MonoBehaviour
{
    GameObject Wrag;
    bool x;
    // Start is called before the first frame update
    void Start()
    {
        Wrag = GameObject.FindWithTag("Orc2");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 2)
        {


            x = true;
        }
        else
        {
            if (transform.position.x >= 9)
            {
                x = false;



            }
        }
        if (x == true)
        {
            transform.position = transform.position + new Vector3(0.007f, 0, 0);
        }
        else
        {
            transform.position = transform.position - new Vector3(0.007f, 0, 0);
        }
    }
}
