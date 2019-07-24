using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    private bool isClicked = false;
    public bool TdoNot = false;
    public bool RdoNot = false;

    public GameObject alpha150 = null;
    private GameObject createalpha = null;
    public GameObject realTower = null;

    private void OnMouseDown()
    {
        isClicked = true;
        createalpha = Instantiate(alpha150, transform);
        createalpha.transform.localScale = new Vector3(1f, 1f, 0);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 1.0f;
        createalpha.transform.position = mousePos;
    }

    private void OnMouseDrag()
    {
        if (isClicked == true)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 1.0f;
            createalpha.transform.position = mousePos;
        }
    }

    private void OnMouseUp()
    {
        isClicked = false;
        if (TdoNot == false&&RdoNot==false)
        {
            Instantiate(realTower, createalpha.transform.position, Quaternion.identity);
        }
        TdoNot = false;
        RdoNot = false;
        Destroy(createalpha);
    }
}