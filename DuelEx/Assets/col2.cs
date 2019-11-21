using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col2 : MonoBehaviour
{
    public GameObject range;
    public GameObject ui;
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player2" && gameObject.name == "Player1H")
        {
            Destroy(GameObject.Find("bull2"));
            Debug.Log(Phy.hppl1);
            GameObject range2 = Instantiate(range, new Vector2(6.10f, -2.57f), Quaternion.Euler(0, 180, 0)) as GameObject;
            range2.name = "range2";
            --Phy.hppl1;
            ui.SetActive(true);
        }
        else if (coll.gameObject.tag == "Player2" && gameObject.name == "Player1B")
        {
            Destroy(GameObject.Find("bull2"));
            Debug.Log(Phy.hppl1);
            GameObject range1 = Instantiate(range, new Vector2(-5.29f, -2.57f), Quaternion.identity) as GameObject;
            range1.name = "range1";
            --Phy.hppl1;
            ui.SetActive(true);
        }
        Timer.timeLeft = 11;
    }
}

