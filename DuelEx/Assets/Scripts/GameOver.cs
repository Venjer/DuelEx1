using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("UI/Text").GetComponent<Text>().text = Var.winner;
    }
}