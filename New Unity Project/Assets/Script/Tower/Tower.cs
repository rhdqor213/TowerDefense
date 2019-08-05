using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject bullet = null;
    public GameObject Range = null;
    public int damage = 0;
    public float speed = 0;
    public List<GameObject> collEnemys = new List<GameObject>();
    public float fireTime = 0;
    public float rotDeg;
    private bool isClicked = false;
    private float timer = 0;

    void Start()
    {
        Range.SetActive(false);
    }

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
                6.0f*Time.deltaTime);

            if (target != null)
            {
                if (timer > fireTime)
                {
                    timer = 0.0f;
                    var aBullet = Instantiate(bullet, transform.position, Quaternion.identity);
                    aBullet.transform.parent = null;
                    aBullet.GetComponent<Bullet>().target = target;
                    aBullet.GetComponent<Bullet>().tower = gameObject;
                    aBullet.transform.localScale = new Vector3(1.5f, 1.5f, 0);
                }
            }
        }
    }

    public void select()
    {
        if (isClicked == true)
        {
            isClicked = false;
            Range.SetActive(false);
        }
        else if (isClicked == false)
        {
            isClicked = true;
            Range.SetActive(true);
        }
    }
}
