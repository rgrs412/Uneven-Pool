using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM : MonoBehaviour
{
    void Awake() {
        if (GameObject.FindGameObjectsWithTag("Bgm").Length > 1) {
            GameObject.Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
        }
    }
    
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Menu" || scene.name == "ControlMenu" || scene.name == "LevelsMenu") {
            PlayMusic();
        } else {
            StopMusic();
        }
    }

    public void PlayMusic()
    {
        if (gameObject.GetComponent<AudioSource>().isPlaying) return;
        gameObject.GetComponent<AudioSource>().Play();
    }

    public void StopMusic()
    {
        gameObject.GetComponent<AudioSource>().Stop();
    }
}
