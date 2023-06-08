using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAudio : MonoBehaviour
{
    void Awake() {
        /*
        GameObject [] gameObjects = GameObject.FindGameObjectsWithTag("ButtonAudio");
        if (gameObjects.Length > 1) {
            DontDestroyOnLoad(gameObjects[gameObjects.Length-1]);
            for(int i=0; i<gameObjects.Length-1;i++) {
                GameObject.Destroy(gameObjects[i]);
            }
        } else {
            DontDestroyOnLoad(gameObject);
        }*/
        if (GameObject.FindGameObjectsWithTag("ButtonAudio").Length > 1) {
            GameObject.Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
        }
    }
}
