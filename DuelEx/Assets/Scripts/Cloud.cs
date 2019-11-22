using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float speed = 0.001f;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj.transform.position = new Vector3(-11.0f, Random.Range(1.91f, 4.58f),1);
    }

    // Update is called once per frame
    void Update()
    {  
        obj.transform.position = new Vector3(obj.transform.position.x + speed * Wind.wind, obj.transform.position.y,1);
        if (obj.transform.position.x >= 10.4f)
        {
            obj.transform.position = new Vector3(-11.0f , Random.Range(1.91f, 4.58f),1);
        }
        if (obj.transform.position.x <= -15)
        {
            obj.transform.position = new Vector3(9.0f, Random.Range(1.91f, 4.58f), 1);
        }
    }
}
