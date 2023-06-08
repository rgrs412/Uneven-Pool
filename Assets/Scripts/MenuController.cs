using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("Level 1");
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void LevelsMenu() {
        SceneManager.LoadScene("LevelsMenu");
    }

    public void LoadLevel1() {
        SceneManager.LoadScene("Level 1");
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void LoadLevel2() {
        SceneManager.LoadScene("Level 2");
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void LoadLevel3() {
        SceneManager.LoadScene("Level 3");
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void LoadLevel4() {
        SceneManager.LoadScene("Level 4");
        Cursor.lockState = CursorLockMode.Locked;
    }


    public void ControlMenu() {
        SceneManager.LoadScene("ControlMenu");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
