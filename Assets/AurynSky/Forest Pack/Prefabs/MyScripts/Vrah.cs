using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vrah : MonoBehaviour
{
    public Space m_RotateSpace;
    public float m_RotateSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * m_RotateSpeed * Time.deltaTime, m_RotateSpace);
    }
}
