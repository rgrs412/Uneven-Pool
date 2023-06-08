using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Goal : MonoBehaviour
{
    public GameObject ball;

    GameObject levelEndMenu;
    Text completeTimeText;
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        levelEndMenu = GameObject.Find("Canvas2");
        completeTimeText = GameObject.Find("CompleteTime").GetComponentInChildren<Text>();
        levelEndMenu.SetActive(false);
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (ball.transform.position.y < -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball") {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            completeTimeText.text = time.ToString("F2") + " s";
            levelEndMenu.SetActive(true);

            /*
            if (SceneManager.GetActiveScene().name == "Level 1") {
                SceneManager.LoadScene("Level 2");
            }
            else if (SceneManager.GetActiveScene().name == "Level 2") {
                SceneManager.LoadScene("Level 3");
            } else if (SceneManager.GetActiveScene().name == "Level 3") {
                SceneManager.LoadScene("WinScreen");
                Cursor.lockState = CursorLockMode.None;
            }
            */
        } 
    }

    public void Continue() {
        Time.timeScale = 1;
        if (SceneManager.GetActiveScene().name == "Level 1") {
            SceneManager.LoadScene("Level 2");
            Cursor.lockState = CursorLockMode.Locked;
        } else if (SceneManager.GetActiveScene().name == "Level 2") {
            SceneManager.LoadScene("Level 3");
            Cursor.lockState = CursorLockMode.Locked;
        } else if (SceneManager.GetActiveScene().name == "Level 3") {
            SceneManager.LoadScene("Level 4");
            Cursor.lockState = CursorLockMode.Locked;
        } else if (SceneManager.GetActiveScene().name == "Level 4") {
            SceneManager.LoadScene("WinScreen");
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
