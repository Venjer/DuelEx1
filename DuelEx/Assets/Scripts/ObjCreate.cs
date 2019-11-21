using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjCreate : MonoBehaviour
{
    public GameObject[] sprites;
    int[] mass;
    int i = 0;
    private static System.Random rng = new System.Random((int)DateTime.Now.Ticks & 0x0000FFFF);
    // Start is called before the first frame update
    void Start()
    {
        mass = new int[3] { UnityEngine.Random.Range(0, 3), UnityEngine.Random.Range(0, 3), UnityEngine.Random.Range(0, 3)};
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
            GameObject obj = Instantiate(sprites[s], new Vector2(-2.6f+ i*3, -2.18f), Quaternion.identity) as GameObject;
            obj.name = s.ToString();

            ++i;
        }
    }
}
