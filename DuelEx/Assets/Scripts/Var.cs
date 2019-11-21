using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Var : MonoBehaviour
{
    public static int mode;
    private void Start()
    {
        DontDestroyOnLoad(GameObject.FindGameObjectWithTag("Var"));
    }
}

