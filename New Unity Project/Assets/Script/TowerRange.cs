using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRange : MonoBehaviour
{
    public GameObject tower = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
            tower.GetComponent<Tower>().collEnemys.Add(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        foreach (GameObject go in tower.GetComponent<Tower>().collEnemys)
        {
            if (go == collision.gameObject)
            {
                tower.GetComponent<Tower>().collEnemys.Remove(go);
                break;
            }
        }
    }
}
