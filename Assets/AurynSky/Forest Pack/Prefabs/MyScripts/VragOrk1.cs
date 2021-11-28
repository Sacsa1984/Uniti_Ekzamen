using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VragOrk1 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Wrag;
    bool x;
    void Start()
    {
        Wrag = GameObject.FindWithTag("Orc1");
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x <= -2.5)
        {


            x = true;
        }
        else
        {
            if (transform.position.x >= 3)
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
