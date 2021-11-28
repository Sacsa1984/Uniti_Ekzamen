using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artifact_T : MonoBehaviour
{
    public Space m_RotateSpace;
    public float m_RotateSpeed = 20f;
    bool x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * m_RotateSpeed * Time.deltaTime, m_RotateSpace);

        if (transform.position.y <= 1)
        {


            x = true;
        }
        else
        {
            if (transform.position.y >= 3)
            {
                x = false;



            }
        }

        if (x == true)
        {
            transform.position = transform.position + new Vector3(0, 0.007f, 0);
        }
        else
        {
            transform.position = transform.position - new Vector3(0, 0.007f, 0);
        }

    }
}
