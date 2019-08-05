using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alpha : MonoBehaviour
{
    public GameObject Range = null;
    public GameObject RangeCircle = null;

    public void Start()
    {
        RangeCircle = Instantiate(Range, transform);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (string.Equals(collision.tag, "Tower"))
            transform.parent.GetComponent<TowerManager>().TdoNot = true;
        if (string.Equals(collision.tag, "Road"))
            transform.parent.GetComponent<TowerManager>().RdoNot = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (string.Equals(collision.tag, "Tower"))
            transform.parent.GetComponent<TowerManager>().TdoNot = false;
        if (string.Equals(collision.tag, "Road"))
            transform.parent.GetComponent<TowerManager>().RdoNot = false;
    }
}
