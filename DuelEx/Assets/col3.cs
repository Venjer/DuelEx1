﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col3 : MonoBehaviour
{
    public GameObject range;
    public GameObject ui;
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(GameObject.Find("bull1"));
            Debug.Log(Phy.hppl2);
            GameObject range2 = Instantiate(range, new Vector2(6.10f, -2.57f), Quaternion.Euler(0, 180, 0)) as GameObject;
            range2.name = "range2";
            ui.SetActive(true);
        }
        else if (coll.gameObject.tag == "Player2")
        {
            Destroy(GameObject.Find("bull2"));
            Debug.Log(Phy.hppl2);
            GameObject range1 = Instantiate(range, new Vector2(-5.29f, -2.57f), Quaternion.identity) as GameObject;
            range1.name = "range1";
            ui.SetActive(true);
        }
    }
}