using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// Manager to check boolean on multiple objects
/// </summary>
public class checkfordonefry : MonoBehaviour
{
    GameObject obj;
    GameObject obj2;
    GameObject obj3;
    GameObject obj4;
    GameObject obj5;
    GameObject obj6;
    GameObject obj7;
    public GameObject Button;
    //public bool 




    //This sets every object to be what is tagged
    void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Exo1");
        obj2 = GameObject.FindGameObjectWithTag("Exo2");
        obj3 = GameObject.FindGameObjectWithTag("ExoTail");
        obj4 = GameObject.FindGameObjectWithTag("ExoLeg1");
        obj5 = GameObject.FindGameObjectWithTag("ExoLeg2");
        obj6 = GameObject.FindGameObjectWithTag("ExoArm1");
        obj7 = GameObject.FindGameObjectWithTag("ExoArm2");
    }

    


    // Update is called once per frame
    //Checks to see if they player has left an object in the right amount of time or too long. If too long player can not advance
    void Update()
    {
        if (obj.GetComponent<CheckForExomorph>().checkfordone && obj2.GetComponent<CheckForExomorph>().checkfordone2 && obj3.GetComponent<CheckForExomorph>().checkfordone3 && obj4.GetComponent<CheckForExomorph>().checkfordone4 && obj5.GetComponent<CheckForExomorph>().checkfordone5 && obj6.GetComponent<CheckForExomorph>().checkfordone6 && obj7.GetComponent<CheckForExomorph>().checkfordone7)
        {
            Button.SetActive(true);
        }

        if (!obj.GetComponent<CheckForExomorph>().checkfordone || !obj2.GetComponent<CheckForExomorph>().checkfordone2 || !obj3.GetComponent<CheckForExomorph>().checkfordone3 || !obj4.GetComponent<CheckForExomorph>().checkfordone4 || !obj5.GetComponent<CheckForExomorph>().checkfordone5 || !obj6.GetComponent<CheckForExomorph>().checkfordone6 || !obj7.GetComponent<CheckForExomorph>().checkfordone7)
        {
            Button.SetActive(false);
        }

        //
        //
        //;
        //;
        //obj6.GetComponent<CheckForExomorph>().checkfordone6;
        //obj7.GetComponent<CheckForExomorph>().checkfordone7;

        //if(checkfordone == true && checkfordone2 == true && checkfordone3 == true && checkfordone4 == true && checkfordone5 == true && checkfordone6 == true && checkfordone7 == true)
        //{
        // Button.SetActive(true);
        //}

    }

}
