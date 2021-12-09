using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public static bool end = false;
    public GameObject EndUI;

    void Start()
    {
        EndUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Cursor.visible = true;
            if(end)
            {
                Resume();
            }
            else
            {
                End();
            }
        }
        
    }
    public void Resume()
    {
        Cursor.visible = false;
        EndUI.SetActive(false);
        Time.timeScale = 1f;
        end = false;
    }
    void End()
    {
        EndUI.SetActive(true);
        Time.timeScale = 0f;
        end = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void ToMenu()
    {
        Debug.Log("To menu");
        SceneManager.LoadScene("Menu");
    }
}
