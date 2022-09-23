using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script checks when each
/// exomorphh has entered the oil and checks how long they cook for
/// </summary>
public class CheckForExomorph : MonoBehaviour
{
    public GameObject fireButton;
    public GameObject Pot;
    public GameObject Button2;
    public int allIn = 0;
    public float cooktime;
    public float cooktime2;
    public float cooktime3;
    public float cooktime4;
    public float cooktime5;
    public float cooktime6;
    public float cooktime7;
    public bool isCooking = false;
    public bool isCooking2 = false;
    public bool isCooking3 = false;
    public bool isCooking4 = false;
    public bool isCooking5 = false;
    public bool isCooking6 = false;
    public bool isCooking7 = false;
    public bool checkfordone = false;
    public bool checkfordone2 = false;
    public bool checkfordone3 = false;
    public bool checkfordone4 = false;
    public bool checkfordone5 = false;
    public bool checkfordone6 = false;
    public bool checkfordone7 = false;
    public GameObject done1;
    public GameObject done2;
    public GameObject done3;
    public GameObject done4;
    public GameObject done5;
    public GameObject done6;
    public GameObject done7;

    public GameObject overdone1;
    public GameObject overdone2;
    public GameObject overdone3;
    public GameObject overdone4;
    public GameObject overdone5;
    public GameObject overdone6;
    public GameObject overdone7;

    

    
    
    //checks for entry withhin the pot's hitbox specifically to avoid 
    //when they are layered on top of each other
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Pot") 
            {
         
            
            if (this.gameObject.name == "Exo 1")
            {
                isCooking = true;
            }
            if (this.gameObject.name == "Exo 2")
            {
                isCooking2 = true;
                
            }
            if (this.gameObject.name == "Exo Tail")
            {
                isCooking3 = true;
                
            }
            if (this.gameObject.name == "Exo Leg 1")
            {
                isCooking4 = true;
                
            }
            if (this.gameObject.name == "Exo Leg 2")
            {
                isCooking5 = true;
                
            }
            if (this.gameObject.name == "Exo Arm 1")
            {
                isCooking6 = true;
                
            }
            if (this.gameObject.name == "Exo Arm 2")
            {
                isCooking7 = true;
                
            }
            }
         

        }

    //Checks for when they leave the pot's hitbox
    //so that it doesn't set numbers to 0 if 
    //the other moveable game objects don't move out of
    //each others hitbox
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pot")
        {
            cooktime = 0;
            cooktime2 = 0;
            cooktime3 = 0;
            cooktime4 = 0;
            cooktime5 = 0;
            cooktime6 = 0;
            cooktime7 = 0;
            isCooking = false;
            isCooking2 = false;
            isCooking3 = false;
            isCooking4 = false;
            isCooking5 = false;
            isCooking6 = false;
            isCooking7 = false;
        }
    }


    //checks for a boolean
    //if the boolean is true then it adds time
    //if time is within certain numbers then it sets the proper game object to be active
    //it also sets a differant boolean true for each one to be checked by the manager
    //sets that same boolean to false if left in area too long and activates restart button
    void Update()
    {
        if (isCooking)
        {
            cooktime += Time.deltaTime;
            if (cooktime >= 7.5 && cooktime < 15)
            {
                done1.SetActive(true);
                checkfordone = true;
                
            }
            if (cooktime >= 15)
            {
                overdone1.SetActive(true);
                Button2.SetActive(true);
                checkfordone = false;

            }
        }
        if (isCooking2)
        {
            cooktime2 += Time.deltaTime;
            if (cooktime2 >= 7.5 && cooktime2 < 15)
            {
                done2.SetActive(true);
                checkfordone2 = true;
            }
            if (cooktime2 >= 15)
            {
                overdone2.SetActive(true);
                Button2.SetActive(true);
                checkfordone2 = false;
            }
        }
        if (isCooking3)
        {
            cooktime3 += Time.deltaTime;
            if (cooktime3 >= 7.5 && cooktime3 < 15)
            {
                done3.SetActive(true);
                checkfordone3 = true;
            }
            if (cooktime3 >= 15)
            {
                overdone3.SetActive(true);
                Button2.SetActive(true);
                checkfordone3 = false;
            }
        }
        if (isCooking4)
        {
            cooktime4 += Time.deltaTime;
            if (cooktime4 >= 7.5 && cooktime4 < 15)
            {
                done4.SetActive(true);
                checkfordone4 = true;
            }
            if (cooktime4 >= 15)
            {
                overdone4.SetActive(true);
                Button2.SetActive(true);
                checkfordone4 = false;
            }
        }
        if (isCooking5)
        {
            cooktime5 += Time.deltaTime;
            if (cooktime5 >= 7.5 && cooktime5 < 15)
            {
                done5.SetActive(true);
                checkfordone5 = true;
            }
            if (cooktime5 >= 15)
            {
                overdone5.SetActive(true);
                Button2.SetActive(true);
                checkfordone5 = false;
            }
        }
        if (isCooking6)
        {
            cooktime6 += Time.deltaTime;
            if (cooktime6 >= 7.5 && cooktime6 < 15)
            {
                done6.SetActive(true);
                checkfordone6 = true;
            }
            if (cooktime6 >= 15)
            {
                overdone6.SetActive(true);
                Button2.SetActive(true);
                checkfordone6 = false;
            }
        }
        if (isCooking7)
        {
            cooktime7 += Time.deltaTime;
            if (cooktime7 >= 7.5 && cooktime7 < 15)
            {
                done7.SetActive(true);
                checkfordone7 = true;
            }
            if (cooktime7 >= 15)
            {
                overdone7.SetActive(true);
                Button2.SetActive(true);
                checkfordone7 = false;
            }
        }

        if (this.gameObject.name == "Exo 1 partway" && this.gameObject.name == "Exo 2 partway" && this.gameObject.name == "Exo Tail partway" && this.gameObject.name == "Exo Leg 1 partway" && this.gameObject.name == "Exo Leg 2 partway" && this.gameObject.name == "Exo Arm 1 partway" && this.gameObject.name == "Exo Arm 2 partway")
        {
            fireButton.SetActive(true);
        }
        //Debug.Log(cooktime4);
        //Debug.Log(isCooking4);
         /*void OnTriggerEnter2D(Collider2D other)
        {
            //Debug.Log("Is in the pot");
            //allIn++;
            //Debug.Log(allIn);
            if (this.gameObject.name == "Exo1")
            {
                cooktime += Time.deltaTime;
                if (cooktime >= 7.5 && cooktime < 15)
                {
                    done1.SetActive(true);
                }
                if (cooktime == 15)
                {
                    overdone1.SetActive(true);
                }
            }*/
        //}
       //if (allIn == 7)
        //{
          //  fireButton.SetActive(true);
        //}
    }
}
