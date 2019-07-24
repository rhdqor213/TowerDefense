using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject bullet = null;
    public int damage = 0;
    public List<GameObject> collEnemys = new List<GameObject>();
    public float fireTime = 0;
    public float rotDeg;
    private float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if (collEnemys.Count > 0)
        {
            GameObject target = collEnemys[0];
            Vector3 targetPos = target.transform.position;

            float dx = targetPos.x - transform.position.x;
            float dy = targetPos.y - transform.position.y;
            rotDeg = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
            transform.localRotation =
                Quaternion.Lerp(transform.localRotation,
                Quaternion.Euler(0f,0f,rotDeg-90),
                /**/5.0f*Time.deltaTime);

            if (target != null)
            {
                if (timer > fireTime)
                {
                    timer = 0.0f;
                    var aBullet = Instantiate(bullet, transform.position, Quaternion.identity, transform);
                    aBullet.GetComponent<Bullet>().targetPos = (targetPos - transform.position).normalized;
                    aBullet.GetComponent<Bullet>().target = target;
                    aBullet.GetComponent<Bullet>().tower = gameObject;
                    aBullet.transform.localScale = new Vector3(0.5f, 0.5f);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
            collEnemys.Add(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        foreach (GameObject go in collEnemys)
        {
            if (go == collision.gameObject)
            {
                collEnemys.Remove(go);
                break;
            }
        }
    }
}
