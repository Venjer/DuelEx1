using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Before : MonoBehaviour
{
    float spe = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Canvas/Text").transform.position = Camera.main.ScreenToWorldPoint(new Vector3(240, -150 + spe,0.3f));
        spe+=0.3f;
        if (GameObject.Find("Canvas/Text").transform.position.y > 25)
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
