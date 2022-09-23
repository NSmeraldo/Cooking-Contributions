using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Used to move pieces of the exomorph based on a boolean
/// </summary>
public class MovingExomorph : MonoBehaviour
{
    private bool IsPicked;

    public void OnMouseDown()
    {
        IsPicked = true;
    }

    public void OnMouseUp()
    {
        IsPicked = false;
    }

    void Update()
    {
        if (IsPicked)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
