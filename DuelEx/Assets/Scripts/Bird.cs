using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public GameObject bird;

    void Update()
    {
        if (GameObject.Find("bird") == null && Random.Range(1, 750) == 3)
        {
            GameObject bird1 = Instantiate(bird, new Vector2(-11.0f, Random.Range(0.5f, 2.3f)), 
                Quaternion.identity) as GameObject;
            bird1.name = "bird";
        }
        if (GameObject.Find("bird") != null)
        {
            GameObject.Find("bird").transform.position = new Vector2(GameObject.Find("bird").
                transform.position.x + 0.13f, GameObject.Find("bird").transform.position.y);
            if (GameObject.Find("bird").transform.position.x >= 10.4f)
            {
                Destroy(GameObject.Find("bird"));
            }
        }
    }
}
