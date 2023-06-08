using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    GameObject cam;
    float startTime;
    float buttonHoldTime;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            startTime = Time.time;
        } else if (Input.GetKeyUp(KeyCode.Space)) {
            buttonHoldTime = 1 + Time.time - startTime;
            //Debug.Log(buttonHoldTime);
            buttonHoldTime = buttonHoldTime*buttonHoldTime;
            if (buttonHoldTime > 3)
            {
                buttonHoldTime = 3;
            }
            gameObject.GetComponent<Rigidbody>().AddForce(cam.transform.forward.x * 500 * buttonHoldTime, 0, cam.transform.forward.z * 500 * buttonHoldTime);
            
        }
        //Debug.DrawRay(cam.transform.position, cam.transform.forward, Color.green);

        else if (gameObject.transform.position.y < -10) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
