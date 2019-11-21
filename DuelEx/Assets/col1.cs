using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col1 : MonoBehaviour
{
    public GameObject range;
    public GameObject ui;
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player" && gameObject.name == "Player2H")
        {
            Destroy(GameObject.Find("bull1"));
            Debug.Log(Phy.hppl2);
            GameObject range1 = Instantiate(range, new Vector2(-5.29f, -2.57f), Quaternion.identity) as GameObject;
            range1.name = "range1";
            --Phy.hppl2;
            ui.SetActive(true);
        }
        else if(coll.gameObject.tag == "Player" && gameObject.name == "Player2B")
        {
            Destroy(GameObject.Find("bull1"));
            Debug.Log(Phy.hppl2);
            GameObject range2 = Instantiate(range, new Vector2(6.10f, -2.57f), Quaternion.Euler(0, 180, 0)) as GameObject;
            range2.name = "range2";
            --Phy.hppl2;
            ui.SetActive(true);
        }
        Timer.timeLeft = 11;
    }
}
