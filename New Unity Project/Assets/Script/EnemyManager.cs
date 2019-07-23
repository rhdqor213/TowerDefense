using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : PathManager
{
    public GameObject mob = null;
    public float regenTime = 0;
    public float timer = 0;
    Vector3 startpos = Vector3.zero;
    private int count = 0;

    void Start()
    {
        startpos = new Vector3(
                (movePath[0].x - 5) * 1.28f,
                (movePath[0].y - 4) * 1.28f);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > regenTime)
        {
            if (count < 20)
            {
                Instantiate(mob, startpos, Quaternion.identity);
                count++;
            }
            timer = 0.0f;
        }
    }
}
