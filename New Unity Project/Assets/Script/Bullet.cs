using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 targetPos = Vector3.zero;
    public GameObject target = null;
    public GameObject tower = null;

    void Update()
    {
        transform.Translate(targetPos * Time.deltaTime * 3.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            target.GetComponent<EnemyMove>().damage(tower.GetComponent<Tower>().damage);
            if (target == null)
                tower.GetComponent<Tower>().collEnemys.Remove(tower.GetComponent<Tower>().collEnemys[0]);
            Destroy(gameObject);
        }
    }
}
