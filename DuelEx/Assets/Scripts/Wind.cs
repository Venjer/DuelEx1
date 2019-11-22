using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public static float wind;
    // Start is called before the first frame update
    void Start()
    {
        wind = Random.Range(-0.5f, 0.5f);
        Debug.Log(wind);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("bull1") != null)
        {
            GameObject.Find("bull1").GetComponent<ConstantForce2D>().force = new Vector2(wind, 
                GameObject.Find("bull1").GetComponent<ConstantForce2D>().force.y);
        }
        if (GameObject.Find("bull2") != null)
        {
            GameObject.Find("bull2").GetComponent<ConstantForce2D>().force = new Vector2(wind,
                GameObject.Find("bull2").GetComponent<ConstantForce2D>().force.y);
        }
    }
}
