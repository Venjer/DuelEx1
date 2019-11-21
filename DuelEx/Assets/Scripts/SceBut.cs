using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceBut : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToScene(string level)
    {
        string nameButton = EventSystem.current.currentSelectedGameObject.name;
        switch (nameButton)
        {
            case "PVP":
                Var.mode = 1;
                break;
            case "PVE":
                Var.mode = 2;
                break;
        }
        SceneManager.LoadScene(level);
    }
    public void ManageScene(string level)
    {
        SceneManager.LoadScene(level);
    }
    public void Close()
    {
        Application.Quit();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) 
        {
        SceneManager.LoadScene("MainMenu");
        }
    }

}
