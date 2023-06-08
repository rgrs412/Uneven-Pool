using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Spring")
        {
            gameObject.GetComponent<AudioSource>().volume = Mathf.Log(gameObject.GetComponent<Rigidbody>().velocity.magnitude, 20f);
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
