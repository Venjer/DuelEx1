using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject range;
    public static float timeLeft = 11;
    void Start()
    {
        timeLeft = 11;
    }
    void FixedUpdate()
    {
        timeLeft -= Time.fixedDeltaTime;
        GameObject.Find("UI/TimeLeft").GetComponent<Text>().text = Convert.ToString((int) timeLeft);
        if (timeLeft < 1)
        {
            if (GameObject.Find("range1") is null)
            {
                Destroy(GameObject.Find("range2"));
                GameObject range1 = Instantiate(range, new Vector2(-5.29f, -2.57f), Quaternion.identity) as GameObject;
                range1.name = "range1";
            }
            else if (GameObject.Find("range2") is null)
            {
                Destroy(GameObject.Find("range1"));
                GameObject range2 = Instantiate(range, new Vector2(6.10f, -2.57f), Quaternion.Euler(0, 180, 0)) as GameObject;
                range2.name = "range2";
            }
            timeLeft = 11;
        }
    }
}
