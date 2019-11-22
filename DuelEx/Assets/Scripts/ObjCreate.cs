using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjCreate : MonoBehaviour
{
    public GameObject[] sprites;
    public Sprite[] heads;
    public Sprite[] bodys;
    public Sprite[] backs;
    int[] mass;
    int[] players;
    int i = 0;
    private static System.Random rng = new System.Random((int)DateTime.Now.Ticks & 0x0000FFFF);
    // Start is called before the first frame update
    void Start()
    {
        mass = new int[3] { UnityEngine.Random.Range(0, 6), UnityEngine.Random.Range(0, 6), UnityEngine.Random.Range(0, 6)};
        for (int i = mass.Length - 1; i >= 1; i--)
        {
            int j = rng.Next(i + 1);
            // обменять значения data[j] и data[i]
            var temp = mass[j];
            mass[j] = mass[i];
            mass[i] = temp;
        }
        
        foreach (int s in mass)
        {
            GameObject obj = Instantiate(sprites[s], new Vector2(-3.19f+ i*3.2f, -2.18f), Quaternion.identity) as GameObject;
            obj.name = s.ToString();

            ++i;
        }
        players = new int[2] { UnityEngine.Random.Range(0, 5), UnityEngine.Random.Range(0, 5) };
        GameObject.Find("Player1H").GetComponent<SpriteRenderer>().sprite = heads[players[0]];
        GameObject.Find("Player1B").GetComponent<SpriteRenderer>().sprite = bodys[players[0]];
        GameObject.Find("Player2H").GetComponent<SpriteRenderer>().sprite = heads[players[1]];
        GameObject.Find("Player2B").GetComponent<SpriteRenderer>().sprite = bodys[players[1]];

        GameObject.Find("back").GetComponent<SpriteRenderer>().sprite = backs[UnityEngine.Random.Range(0, 2)];
    }

}
