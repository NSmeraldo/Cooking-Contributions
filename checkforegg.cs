using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This Script checks which hitbox it has entered based on tag for the exomorph flour scene
/// </summary>
public class checkforegg : MonoBehaviour
{
    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;
    public GameObject egg4;
    public GameObject egg5;
    public GameObject egg6;
    public GameObject egg7;

    public GameObject flour1;
    public GameObject flour2;
    public GameObject flour3;
    public GameObject flour4;
    public GameObject flour5;
    public GameObject flour6;
    public GameObject flour7;

    public bool Flour1 = false;
    public bool Flour2 = false;
    public bool Flour3 = false;
    public bool Flour4 = false;
    public bool Flour5 = false;
    public bool Flour6 = false;
    public bool Flour7 = false;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Bowl")
        {
            if(this.gameObject.name == "Exomorph one")
            {
                egg1.SetActive(true);
                Debug.Log(Flour1);

            }
            if(this.gameObject.name == "Exomorph two")
            {
                egg2.SetActive(true);

            }
            if(this.gameObject.name == "Exomorph tail")
            {
                egg3.SetActive(true);

            }
            if(this.gameObject.name == "leg 1")
            {
                egg4.SetActive(true);

            }
            if(this.gameObject.name == "leg 2")
            {
                egg5.SetActive(true);

            }
            if(this.gameObject.name == "arm 1")
            {
                egg6.SetActive(true);

            }
            if(this.gameObject.name == "arm 2")
            {
                egg7.SetActive(true);

            }
            
        }
         if (col.gameObject.tag == "Flour")
        {
           
            if (this.gameObject.name == "Exomorph one egg")
            {
                flour1.SetActive(true);
                Flour1 = true;
                Debug.Log(Flour1);

            }
            else if (this.gameObject.name == "Exomorph two egg")
            {
                flour2.SetActive(true);
                Flour2 = true;
                Debug.Log(Flour2);

            }
            else if (this.gameObject.name == "Exomorph tail egg")
            {
                flour3.SetActive(true);
                Flour3 = true;
                Debug.Log(Flour3);

            }
            else if(this.gameObject.name == "leg 1 egg")
            {
                flour4.SetActive(true);
                Flour4 = true;
                Debug.Log(Flour4);

            }
            else if(this.gameObject.name == "leg 2 egg")
            {
                flour5.SetActive(true);
                Flour5 = true;
                Debug.Log(Flour5);

            }
            else if(this.gameObject.name == "arm 1 egg")
            {
                flour6.SetActive(true);
                Flour6 = true;
                Debug.Log(Flour6);

            }
            else if(this.gameObject.name == "arm 2 egg")
            {
                flour7.SetActive(true);
                Flour7= true;
                Debug.Log(Flour7);

            }
        }

    }
    /*private void OnCollisionEnter2D(Collision2D col2)
    {
        if (col2.gameObject.tag == "Flour")
        {
            if (this.gameObject.name == "Exomorph one egg")
            {
                flour1.SetActive(true);

            }
            if (this.gameObject.name == "Exomorph two")
            {
                flour2.SetActive(true);

            }
            if (this.gameObject.name == "Exomorph tail")
            {
                flour3.SetActive(true);

            }
            if (this.gameObject.name == "leg 1")
            {
                flour4.SetActive(true);

            }
            if (this.gameObject.name == "leg 2")
            {
                flour5.SetActive(true);

            }
            if (this.gameObject.name == "arm 1")
            {
                flour6.SetActive(true);

            }
            if (this.gameObject.name == "arm 2")
            {
                flour7.SetActive(true);

            }
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
