using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerScript : MonoBehaviour
{
    public GameObject levelEndMenu;
    public GameObject topDownCamera;
    public GameObject mainCamera;

    public GameObject mainBall;

    public GameObject crossHair;
    bool originalCrossHairState;
    LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        //levelEndMenu = GameObject.Find("Canvas2");
        lr = mainBall.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !levelEndMenu.activeSelf && !topDownCamera.activeSelf)
        {
            ToggleActive(crossHair);
        }

        if (Input.GetKeyDown(KeyCode.R) && !levelEndMenu.activeSelf)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.W) && !levelEndMenu.activeSelf)
        {
            if (!topDownCamera.activeSelf) {
                originalCrossHairState = crossHair.activeSelf;
                crossHair.SetActive(false);
            } else {
                crossHair.SetActive(originalCrossHairState);
            }

            ToggleActive(topDownCamera);
            ToggleActiveLR(lr);
        }
        
        if (topDownCamera.activeSelf) {
            //Debug.DrawRay(mainBall.transform.position, new Vector3(mainCamera.transform.forward.x,0,mainCamera.transform.forward.z), Color.green);
            topDownCamera.transform.position = new Vector3(0,5.5f,0) + mainBall.transform.position;
            lr.SetPosition(0, mainBall.transform.position);
            lr.SetPosition(1, mainBall.transform.position + new Vector3(mainCamera.transform.forward.x,0,mainCamera.transform.forward.z));
        }
    }

    void ToggleActive(GameObject obj) {
        if(obj.activeSelf) {
            obj.SetActive(false);
        } else {
            obj.SetActive(true);
        }
    }

    void ToggleActiveLR(LineRenderer obj) {
        if(obj.enabled) {
            obj.enabled = false;
        } else {
            obj.enabled = true;
        }
    }
}
