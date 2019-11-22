using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject range;
    public GameObject ui;
    public GameObject bull2;
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
                GameObject range1 = Instantiate(range, new Vector2(-6.21f, -2.57f), Quaternion.identity) as GameObject;
                range1.name = "range1";
            }
            else if (GameObject.Find("range2") is null)
            {
                
                if (Var.mode == 1)
                {
                    Destroy(GameObject.Find("range1"));
                    GameObject range2 = Instantiate(range, new Vector2(6.10f, -2.57f), Quaternion.Euler(0, 180, 0)) as GameObject;
                    range2.name = "range2";
                }
                else
                {
                    Destroy(GameObject.Find("range1"));
                    GameObject bull = Instantiate(bull2, new Vector2(6.5f, -3), Quaternion.identity) as GameObject;
                    bull.name = "bull2";
                    bull.GetComponent<Rigidbody2D>().AddForce(new Vector2(UnityEngine.Random.Range(11, 14) * -10, 
                    UnityEngine.Random.Range(3, 4) * 105));
                    ui.SetActive(false);
                }
            }
            timeLeft = 11;
            Wind.wind = UnityEngine.Random.Range(-0.5f, 0.5f);
        }
    }
}
