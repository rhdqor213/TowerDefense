using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alpha : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (string.Equals(collision.tag, "Tower"))
            transform.parent.GetComponent<TowerManager>().TdoNot = true;
        if (string.Equals(collision.tag, "Road"))
            transform.parent.GetComponent<TowerManager>().RdoNot = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (string.Equals(collision.tag, "Tower"))
            transform.parent.GetComponent<TowerManager>().TdoNot = false;
        if (string.Equals(collision.tag, "Road"))
            transform.parent.GetComponent<TowerManager>().RdoNot = false;
    }
}
