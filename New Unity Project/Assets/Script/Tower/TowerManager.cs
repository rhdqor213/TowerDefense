using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    private bool isClicked = false;
    public bool TdoNot = false;
    public bool RdoNot = false;
    public int money = 0;

    public GameObject manager = null;
    public GameObject square;
    public GameObject alpha150 = null;
    private GameObject createalpha = null;
    public GameObject realTower = null;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
    }

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
        if (TdoNot == false && RdoNot == false && manager.GetComponent<GameManager>().money >= this.money)
        {
            manager.GetComponent<GameManager>().money -= this.money;
            Instantiate(realTower, createalpha.transform.position, Quaternion.identity);
        }
        TdoNot = false;
        RdoNot = false;
        Destroy(createalpha);
    }

    private void OnMouseOver()
    {
        if (square.GetComponent<MouseCheck>().e == false)
            transform.parent.position += new Vector3(0f, 1.35f, 0f);
        square.GetComponent<MouseCheck>().e = true;
    }
}