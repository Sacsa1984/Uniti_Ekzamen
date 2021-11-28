using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class PlaerDvig : MonoBehaviour
{

    //public TMP_Text missionTitleText;

   




    // Start is called before the first frame update
    GameObject player;
    GameObject topor;
    GameObject copy;
    GameObject chit;
    GameObject ticwa1;
    GameObject ticwa2;
    GameObject ticwa3;
    GameObject VragOrc1;
    GameObject texst;
    GameObject kazan1;
    GameObject kazan2;
    GameObject VragOrc2;

    




    int Sila = 0;
    int Zashita = 0;
    int ochki = 0;
    void Start()
    {
        
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.SetText("Сила ");



        player = GameObject.FindWithTag("Player");
        topor= GameObject.FindWithTag("Topor");
        copy = GameObject.FindWithTag("Copy");
        chit = GameObject.FindWithTag("Chit");
        ticwa1 = GameObject.FindWithTag("Ticwa1");
        ticwa2 = GameObject.FindWithTag("Ticwa2");
        ticwa3 = GameObject.FindWithTag("Ticwa3");
        VragOrc1= GameObject.FindWithTag("Orc1");
        VragOrc2 = GameObject.FindWithTag("Orc2");
       
        kazan1 = GameObject.FindWithTag("Kazan1");
        kazan2 = GameObject.FindWithTag("Kazan2");
      
    }
    
    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.CompareTag("Orc1"))
        {
            

            if (Sila > 3 && Zashita > 3)
            {
                Destroy(VragOrc1);

                Sila -= 2;
                Zashita -= 2;
                ochki += 100;

            }
            else
            {
                Sila = 0;
                Zashita = 0;
                Destroy(player);
            }

        }
        if (otherObj.gameObject.CompareTag("Less1"))
        {
            transform.position = new Vector3(-3f, 2.33f, 5.1f);
           
        }
        if (otherObj.gameObject.CompareTag("Less2"))
        {
            transform.position = new Vector3(-3f, 4.33f, 5.1f);

        }
        if (otherObj.gameObject.CompareTag("Less4"))
        {
            transform.position = new Vector3(2f, 2.7f, 5.1f);

        }

        if (otherObj.gameObject.CompareTag("Kazan1"))
        {
            Destroy(kazan1);
            Sila += 5;
        }
        if (otherObj.gameObject.CompareTag("Kazan2"))
        {
            Destroy(kazan2);
            Zashita += 5;
        }
        if (otherObj.gameObject.CompareTag("Orc2"))
        {


            if (Sila > 5 && Zashita >4)
            {
                Destroy(VragOrc2);

                Sila -= 3;
                Zashita -= 3;
                ochki += 150;

            }
            else
            {
                Sila = 0;
                Zashita = 0;
                Destroy(player);
            }

        }

    }


        // Update is called once per frame
        void Update()
    {

    

        float distanceHor = 2 * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * distanceHor);

        float distanceVer = 2 * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * distanceVer);

      

        if (transform.rotation.x != 0)
        {
            transform.localEulerAngles = new Vector3(0,0, 0);
         
        }


        if(transform.position.x <-6.5&& transform.position.z < -8.5)
        {
            Sila += 2;
            Destroy(topor);
        }

        if (transform.position.x < -3 && transform.position.z < -4&& transform.position.z > -5)
        {
            Sila += 2;
            Destroy(copy);
        }
        if (transform.position.x < 6.8 && transform.position.x > 5&& transform.position.z > -5 )
        {
            Zashita += 4;
            Destroy(chit);
        }
        if (transform.position.x < -4.5 && transform.position.x > -5 && transform.position.z > -5 && transform.position.z > -6)
        {
            ochki += 10;
            Destroy(ticwa1);
        }
        if (transform.position.x < -5 && transform.position.x > -5.6 && transform.position.z > -0.8 && transform.position.z > -1.2)
        {
            ochki += 10;
            Destroy(ticwa2);
        }
        if (transform.position.x < 3.4 && transform.position.x > 3 && transform.position.z > -0.8 && transform.position.z > -1.2)
        {
            ochki += 10;
            Destroy(ticwa3);
        }

    }


}
