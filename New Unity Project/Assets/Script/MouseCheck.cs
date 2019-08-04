using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCheck : MonoBehaviour
{
    public bool e = false;
    void OnMouseOver()
    {
        if (e == false)
            transform.position += new Vector3(0f, 1.5f, 0f);
        e = true;
    }

    void OnMouseExit()
    {
        if (e == true)
            transform.position -= new Vector3(0f, 1.5f, 0f);
        e = false;
    }
}
