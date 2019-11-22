using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col1 : MonoBehaviour
{
    public GameObject range;
    public GameObject ui;
    public GameObject bull2;
    public AudioClip sound;
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player" && gameObject.name == "Player2H")
        {
            Destroy(GameObject.Find("bull1"));
            Debug.Log(Phy.hppl2);
            --Phy.hppl2;
            ui.SetActive(true);
            Wind.wind = Random.Range(-0.5f, 0.5f);

            GameObject range1 = Instantiate(range, new Vector2(-6.21f, -2.57f), Quaternion.identity) as GameObject;
            range1.name = "range1";

        }
        else if(coll.gameObject.tag == "Player" && gameObject.name == "Player2B")
        {
            Destroy(GameObject.Find("bull1"));
            Debug.Log(Phy.hppl2);
            --Phy.hppl2;
            ui.SetActive(true);
            Wind.wind = Random.Range(-0.5f, 0.5f);
            if (Var.mode == 1)
            {
                GameObject range2 = Instantiate(range, new Vector2(6.10f, -2.57f), Quaternion.Euler(0, 180, 0)) as GameObject;
                range2.name = "range2";
            }
            else
            {
                GameObject bull = Instantiate(bull2, new Vector2(6.5f, -3), Quaternion.identity) as GameObject;
                bull.name = "bull2";
                bull.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(11, 14) * -10, Random.Range(3, 4) * 105));
                ui.SetActive(false);
            }
        }
        Timer.timeLeft = 11;
        GetComponent<AudioSource>().PlayOneShot(sound);
    }
}
