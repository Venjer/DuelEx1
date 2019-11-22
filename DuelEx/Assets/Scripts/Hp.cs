using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public GameObject HpBar;
    public GameObject HpP;


    // Update is called once per frame
    void Update()
    {
        switch (Phy.hppl1)
        {

            case 0:
                Destroy(GameObject.Find("HPP (2)"));
                SceneManager.LoadScene("GameOver");
                Var.winner="Игрок 2 победил!";
                Debug.Log(Var.winner);
                break;
            case 1:
                Destroy(GameObject.Find("HPP (1)"));
                break;
            case 2:
                Destroy(GameObject.Find("HPP"));
                break;
        }
        switch (Phy.hppl2)
        {
            case 0:
                Destroy(GameObject.Find("HPP (5)"));
                SceneManager.LoadScene("GameOver");
                Var.winner = "Игрок 1 победил!";
                Debug.Log(Var.winner);
                break;
            case 1:
                Destroy(GameObject.Find("HPP (4)"));
                break;
            case 2:
                Destroy(GameObject.Find("HPP (3)"));
                break;
        }
    }
}