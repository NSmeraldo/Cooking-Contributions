using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
/// <summary>
/// Legacy slider controller to show progress of cooking
/// Time increased the slider visually
/// </summary>
public class SliderController : MonoBehaviour
{
    //public Text valueText

    public Slider mainSlider;

    public GameObject Button;

    float Timing;

    bool Iscounting = false;

    public GameObject partway1;
    public GameObject partway2;
    public GameObject partway3;
    public GameObject partway4;
    public GameObject partway5;
    public GameObject partway6;
    public GameObject partway7;

    public GameObject done1;
    public GameObject done2;
    public GameObject done3;
    public GameObject done4;
    public GameObject done5;
    public GameObject done6;
    public GameObject done7;


    public void OnSliderChanged(float value)
    {
        if (value >= 7.5 && value <15)
        {
            partway1.SetActive(true);
            partway2.SetActive(true);
            partway3.SetActive(true);
            partway4.SetActive(true);
            partway5.SetActive(true);
            partway6.SetActive(true);
            partway7.SetActive(true);
            Button.SetActive(true);
        }

        if (value == 15)
        {
            done1.SetActive(true);
            done2.SetActive(true);
            done3.SetActive(true);
            done4.SetActive(true);
            done5.SetActive(true);
            done6.SetActive(true);
            done7.SetActive(true);
            //Button.SetActive(true);
        }

        

    }

    void Update()
    {
        if (Iscounting)
        {
            Timing += Time.deltaTime;
            mainSlider.value = Timing;
        }
   
    }

    public void ChangeCounting()
    {
        Iscounting = !Iscounting;
    }
}
