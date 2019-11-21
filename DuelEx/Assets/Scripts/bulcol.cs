using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulcol : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter()
    {
        Debug.Log("Hit Something");  // Передаем сообщение в консоль Unity  
    }
}