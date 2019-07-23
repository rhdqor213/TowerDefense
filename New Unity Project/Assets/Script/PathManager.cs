using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    public class MovePath
    {
        public int x = 0;
        public int y = 0;
        public MovePath(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public static List<MovePath> movePath = new List<MovePath>();
    // Start is called before the first frame update
    void Start()
    {
        movePath.Add(new MovePath(3, 8));
        movePath.Add(new MovePath(3, 7));
        movePath.Add(new MovePath(3, 6));
        movePath.Add(new MovePath(2, 6));
        movePath.Add(new MovePath(1, 6));
        movePath.Add(new MovePath(1, 5));
        movePath.Add(new MovePath(2, 5));
        movePath.Add(new MovePath(2, 4));
        movePath.Add(new MovePath(2, 3));
        movePath.Add(new MovePath(1, 3));
        movePath.Add(new MovePath(0, 3));
        movePath.Add(new MovePath(0, 2));
        movePath.Add(new MovePath(0, 1));
        movePath.Add(new MovePath(1, 1));
        movePath.Add(new MovePath(2, 1));
        movePath.Add(new MovePath(3, 1));
        movePath.Add(new MovePath(3, 2));
        movePath.Add(new MovePath(3, 3));
        movePath.Add(new MovePath(3, 4));
        movePath.Add(new MovePath(4, 4));
        movePath.Add(new MovePath(5, 4));
        movePath.Add(new MovePath(6, 4));
        movePath.Add(new MovePath(7, 4));
        movePath.Add(new MovePath(7, 5));
        movePath.Add(new MovePath(7, 6));
        movePath.Add(new MovePath(7, 7));
        movePath.Add(new MovePath(8, 7));
        movePath.Add(new MovePath(9, 7));
        movePath.Add(new MovePath(10, 7));
        movePath.Add(new MovePath(10, 6));
        movePath.Add(new MovePath(10, 5));
        movePath.Add(new MovePath(9, 5));
        movePath.Add(new MovePath(8, 5));
        movePath.Add(new MovePath(8, 4));
        movePath.Add(new MovePath(8, 3));
        movePath.Add(new MovePath(9, 3));
        movePath.Add(new MovePath(9, 2));
        movePath.Add(new MovePath(8, 2));
        movePath.Add(new MovePath(7, 2));
        movePath.Add(new MovePath(7, 1));
        movePath.Add(new MovePath(7, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
