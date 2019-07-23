using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject mob = null;
    public float regenTime = 0;
    public float timer = 0;
    Vector3 startpos = new Vector3(
                (PathManager.movePath[0].x - 5) * 1.28f,
                (PathManager.movePath[0].y - 4) * 1.28f);
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
