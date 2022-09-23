using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkforflour : MonoBehaviour
{
    GameObject obj;
    GameObject obj2;
    GameObject obj3;
    GameObject obj4;
    GameObject obj5;
    GameObject obj6;
    GameObject obj7;
    public GameObject Button;

    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obj = GameObject.FindGameObjectWithTag("Exo1");
        obj2 = GameObject.FindGameObjectWithTag("Exo2");
        obj3 = GameObject.FindGameObjectWithTag("ExoTail");
        obj4 = GameObject.FindGameObjectWithTag("ExoLeg1");
        obj5 = GameObject.FindGameObjectWithTag("ExoLeg2");
        obj6 = GameObject.FindGameObjectWithTag("ExoArm1");
        obj7 = GameObject.FindGameObjectWithTag("ExoArm2");
        if (obj.GetComponent<checkforegg>().Flour1 && obj2.GetComponent<checkforegg>().Flour2 && obj3.GetComponent<checkforegg>().Flour3 && obj4.GetComponent<checkforegg>().Flour4 && obj5.GetComponent<checkforegg>().Flour5 && obj6.GetComponent<checkforegg>().Flour6 && obj7.GetComponent<checkforegg>().Flour7)
        {
            Button.SetActive(true);
        }
    }
}
