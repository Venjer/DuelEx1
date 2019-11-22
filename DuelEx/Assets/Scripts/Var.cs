using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Var : MonoBehaviour
{
    public static int mode;
    public static string winner;
    private void Start()
    {
        DontDestroyOnLoad(GameObject.Find("Var"));
    }
}

