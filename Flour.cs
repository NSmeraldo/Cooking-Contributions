using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

/// <summary>
/// Legacy version of the checks for the flour scene. Now use checkforflour
/// </summary>
public class Flour : MonoBehaviour, IDropHandler
{
    private int amountDropped = 0;
    public GameObject Button;
    public GameObject ExoMorph1;
    public GameObject ExoMorph2;
    public GameObject ExoMorph3;
    public GameObject ExoMorph4;
    public GameObject ExoMorph5;
    public GameObject ExoMorph6;
    public GameObject ExoMorph7;
    public GameObject ExoMorph8;
    public GameObject ExoMorph9;
    public GameObject ExoMorph10;
    public GameObject ExoMorph11;
    public GameObject ExoMorph12;
    public GameObject ExoMorph13;
    public GameObject ExoMorph14;
    public GameObject ExoMorph15;
    public GameObject ExoMorph16;
    public GameObject ExoMorph17;
    public GameObject ExoMorph18;
    public GameObject ExoMorph19;
    public GameObject ExoMorph20;
    public GameObject ExoMorph21;
    public AudioSource audioData;
    public GameObject Bowl;
    public GameObject FlourPan;



    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            //amountDropped++;

            if(this.gameObject == Bowl && amountDropped == 0)
            {
                amountDropped++;
            }
            else if(this.gameObject == Bowl && amountDropped >= 1)
            {
                amountDropped += 2;
            }
            else if(this.gameObject == FlourPan)
            {
                amountDropped += 2;
            }
            Debug.Log(amountDropped);
        }

        
            if (amountDropped == 1)
            {
                //ExoMorph1.SetActive(false);
                ExoMorph2.SetActive(true);
            }

            if (amountDropped == 2)
            {
                ExoMorph2.SetActive(false);
                ExoMorph3.SetActive(true);
                audioData.Play(0);
            
            }

            if (amountDropped == 3)
            {
                ExoMorph3.SetActive(false);
                ExoMorph1.SetActive(false);
                ExoMorph5.SetActive(true);
                
                
            }

            if (amountDropped == 4)
            {
                ExoMorph5.SetActive(false);
                ExoMorph6.SetActive(true);
                audioData.Play(0);
            }

            if (amountDropped == 5)
            {
                ExoMorph6.SetActive(false);
                ExoMorph4.SetActive(false);
                ExoMorph8.SetActive(true);
                
            }

            if (amountDropped == 6)
            {
                ExoMorph8.SetActive(false);
                ExoMorph9.SetActive(true);
                audioData.Play(0);
            
            }

            if (amountDropped == 7)
            {
                ExoMorph9.SetActive(false);
                ExoMorph7.SetActive(false);
                ExoMorph11.SetActive(true);
                
            }

            if (amountDropped == 8)
            {
                ExoMorph11.SetActive(false);
                ExoMorph12.SetActive(true);
                audioData.Play(0);
            }

            if (amountDropped == 9)
            {
                ExoMorph12.SetActive(false);
                ExoMorph10.SetActive(false);
                ExoMorph14.SetActive(true);
                
            }

            if (amountDropped == 10)
            {
                ExoMorph14.SetActive(false);
                ExoMorph15.SetActive(true);
                audioData.Play(0);
            }

            if (amountDropped == 11)
            {
                ExoMorph15.SetActive(false);
                ExoMorph13.SetActive(false);
                ExoMorph17.SetActive(true);
                
            }

            if (amountDropped == 12)
            {
                ExoMorph17.SetActive(false);
                ExoMorph18.SetActive(true);
                audioData.Play(0);
            }

            if (amountDropped == 13)
            {
                ExoMorph18.SetActive(false);
                ExoMorph16.SetActive(false);
                ExoMorph20.SetActive(true);
                
            }

            if (amountDropped == 14)
            {
                ExoMorph20.SetActive(false);
                ExoMorph21.SetActive(true);
                Button.SetActive(true);
                audioData.Play(0);
            }
        

    }
}


