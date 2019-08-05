using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : PathManager
{
    public GameObject mob1 = null;
    public GameObject mob2 = null;
    public float regenTime = 0;
    public float timer = 0;
    public int money = 100;
    public int cmoney;
    public Text moneyText;

    Vector3 startpos = Vector3.zero;
    private int count = 0;
    private GameObject selectedTower = null;

    void Start()
    {
        cmoney = money;
        startpos = new Vector3(
                (movePath[0].x - 5) * 1.28f,
                (movePath[0].y - 4) * 1.28f);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickDetect();
        }

        timer += Time.deltaTime;
        if (timer > regenTime)
        {
            if (count < 20)
            {
                Instantiate(mob1, startpos, Quaternion.identity);
                count++;
            }
            else if (count < 40)
            {
                Instantiate(mob2, startpos, Quaternion.identity);
                count++;
            }
            timer = 0.0f;
        }

        if (money > cmoney)
            cmoney++;
        if (money < cmoney - 1)
            cmoney -= 2;
        else if (money < cmoney)
            cmoney--;
        moneyText.text = cmoney.ToString();
    }

    private void ClickDetect()
    {
        bool onHit = false;

        Vector2 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Ray2D ray = new Ray2D(wp, Vector2.zero);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
        Debug.Log(hit.collider!=null);
        if (hit.collider != null)
        {
            string HitObj = (hit.transform.gameObject.tag);
            Debug.Log(HitObj + "맞음");
            if (HitObj == "Tower")
            {
                if (selectedTower != null)
                {
                    selectedTower.GetComponent<Tower>().select();
                }

                selectedTower = hit.transform.gameObject;
                selectedTower.GetComponent<Tower>().select();

                onHit = true;
            }
        }
        if (onHit == false)
        {
            if (selectedTower != null)
            {
                selectedTower.GetComponent<Tower>().select();
            }
            selectedTower = null;
        }
    }

}
