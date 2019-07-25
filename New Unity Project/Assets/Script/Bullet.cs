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
        if (target == null)
            Destroy(gameObject);
        else
        {
            targetPos = (target.transform.position - transform.position).normalized;
            transform.position += tower.GetComponent<Tower>().speed * targetPos * Time.deltaTime;
            transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPos).normalized;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            if (target == null){
                tower.GetComponent<Tower>().collEnemys.Remove(tower.GetComponent<Tower>().collEnemys[0]);
                Destroy(gameObject);
            }
            else
            {
                target.GetComponent<EnemyMove>().damage(tower.GetComponent<Tower>().damage);
                Destroy(gameObject);
            }
        }
    }
}
