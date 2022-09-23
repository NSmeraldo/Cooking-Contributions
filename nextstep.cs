using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Initial Script written by Julia 
/// next() changed by Nick
/// </summary>
public class nextstep : MonoBehaviour
{
    public void reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //go to next step in the build index. This is specifically for buttons
        /*if (SceneManager.GetActiveScene().name == "Stir")
        {
            SceneManager.LoadScene("VN_MeetXenon");
        }

        if (SceneManager.GetActiveScene().name == "Egg")
        {
            SceneManager.LoadScene("Stir");
        }

        if(SceneManager.GetActiveScene().name == "Spice")
        {
            SceneManager.LoadScene("Cutter");
        }

        if(SceneManager.GetActiveScene().name == "Cutter")
        {
            SceneManager.LoadScene("Flour");
        }

        if (SceneManager.GetActiveScene().name == "Flour")
        {
            SceneManager.LoadScene("Fry");
        }
        if (SceneManager.GetActiveScene().name == "VNBored")
        {
            SceneManager.LoadScene("KamaryStep1Pressure");
        }

        if (SceneManager.GetActiveScene().name == "KamaryStep1Pressure")
        {
            SceneManager.LoadScene("KamaryStep2CutOnion");
        }
        if (SceneManager.GetActiveScene().name == "KamaryStep2CutOnion")
        {
            SceneManager.LoadScene("KamaryStep3CutPepper");
        }
        if (SceneManager.GetActiveScene().name == "KamaryStep3CutPepper")
        {
            SceneManager.LoadScene("KamaryStep4Combine");
        }
        if (SceneManager.GetActiveScene().name == "KamaryStep4Combine")
        {
            SceneManager.LoadScene("KamaryStep5Crack");
        }
        if (SceneManager.GetActiveScene().name == "KamaryStep5Crack")
        {
            SceneManager.LoadScene("KamaryStep6Smash");
        }
        if (SceneManager.GetActiveScene().name == "KamaryStep6Smash")
        {
            SceneManager.LoadScene("KamaryStep7Final");
        }
        if (SceneManager.GetActiveScene().name == "RamenStep1")
        {
            SceneManager.LoadScene("RamenStep2");
        }
        if (SceneManager.GetActiveScene().name == "RamenStep2")
        {
            SceneManager.LoadScene("RamenStep3");
        }
        if (SceneManager.GetActiveScene().name == "RamenStep3")
        {
            SceneManager.LoadScene("RamenStep4");
        }
        if (SceneManager.GetActiveScene().name == "RamenStep4")
        {
            SceneManager.LoadScene("RamenStep5");
        }*/

    }
}
