using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu = GameObject.Find("Canvas1");
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {
            if(pauseMenu.activeSelf == false) {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            } else {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    public void Continue() {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
