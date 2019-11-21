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
        obj.transform.position = new Vector2(-11.0f, Random.Range(1.91f, 4.58f));
    }

    // Update is called once per frame
    void Update()
    {  
        obj.transform.position = new Vector2(obj.transform.position.x + speed, obj.transform.position.y);
        if (obj.transform.position.x >= 10.4f)
        {
            obj.transform.position = new Vector2(-11.0f, Random.Range(1.91f, 4.58f));
        }
    }
}
