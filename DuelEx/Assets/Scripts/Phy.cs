using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phy : MonoBehaviour
{

    public GameObject bull1;
    public GameObject bull2;
    public GameObject range;
    public GameObject ui;
    public static int hppl1;
    public static int hppl2;
    // Start is called before the first frame update
    void Start()
    {
        //obj.AddForce(new Vector2(500, 500));
        GameObject range1 = Instantiate(range, new Vector2(-6.21f, -2.57f), Quaternion.identity) as GameObject;//Создал ренж
        range1.name = "range1";
        hppl1 = 3;
        hppl2 = 3;
        Debug.Log(Var.mode);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit;
            hit = Physics2D.Raycast(Camera.allCameras[0].ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject.name == "range1")
            {
                GameObject bull = Instantiate(bull1, new Vector2(-6.39f, -2.57f), Quaternion.identity) as GameObject;
                bull.name = "bull1";
                Destroy(GameObject.Find("range1"));
                Debug.Log(Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y)));
                bull.GetComponent<Rigidbody2D>().AddForce(Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x * 80, Input.mousePosition.y * 100)));
                ui.SetActive(false);
            }
            if (hit.collider != null && hit.collider.gameObject.name == "range2")
            {
                GameObject bull = Instantiate(bull2, new Vector2(6.5f, -3.0f), Quaternion.identity) as GameObject;
                bull.name = "bull2";
                Destroy(GameObject.Find("range2"));
                Debug.Log(Camera.main.ScreenToWorldPoint(new Vector2((Input.mousePosition.x), (Input.mousePosition.y))));
                bull.GetComponent<Rigidbody2D>().AddForce(Camera.main.ScreenToWorldPoint(new Vector2((Input.mousePosition.x) * -10, (Input.mousePosition.y) * 105)));
                ui.SetActive(false);
            }
        }
        if (GameObject.Find("bull1") != null)
        {
           if (GameObject.Find("bull1").transform.position.y <= -5.0f)
            {
                Destroy(GameObject.Find("bull1"));
                Timer.timeLeft = 11;
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
                    Debug.Log(Camera.main.ScreenToWorldPoint(new Vector2(7.0f * -10, -1.7f * 105)));
                    bull.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(11, 14) * -10, Random.Range(3, 4) * 105));
                    //bull.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(5, 6.1f) * -10, Random.Range(-1.7f, -2.1f) * 105));
                    ui.SetActive(false);
                }
            } 
        }
        if (GameObject.Find("bull2") != null)
        {
            if (GameObject.Find("bull2").transform.position.y <= -5.0f)
            {
                Destroy(GameObject.Find("bull2"));
                GameObject range1 = Instantiate(range, new Vector2(-6.21f, -2.57f), Quaternion.identity) as GameObject;
                range1.name = "range1";
                Timer.timeLeft = 11;
                ui.SetActive(true);
                Wind.wind = Random.Range(-0.5f, 0.5f);
            }
        }
        
    }
}