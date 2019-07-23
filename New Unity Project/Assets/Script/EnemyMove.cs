using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 0;
    private List<PathManager.MovePath> movePath = null;
    private int nowCount = 0;
    private int maxCount = 0;
    private float timer = 0;

    private Vector3 nowPos = Vector3.zero;
    private Vector3 newPos = Vector3.zero;

    void Start()
    {
        movePath = PathManager.movePath;
        maxCount = movePath.Count;
    }

    void Update()
    {
        timer += Time.deltaTime * speed;

        nowPos = new Vector3(movePath[nowCount].x - 5, movePath[nowCount].y - 4, 0);
        newPos = new Vector3(movePath[nowCount + 1].x - 5, movePath[nowCount + 1].y - 4, 0);

        float x = Mathf.Lerp(nowPos.x * 1.28f, newPos.x * 1.28f, timer);
        float y = Mathf.Lerp(nowPos.y * 1.28f, newPos.y * 1.28f, timer);
        transform.position = new Vector3(x, y, 0);

        if (timer >= 1.0f)
        {
            timer = 0;
            nowCount++;
            if (nowCount >= maxCount-1)
                Destroy(gameObject);
        }
    }
}
