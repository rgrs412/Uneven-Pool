using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringController : MonoBehaviour
{
    public float forward_Thrust = 0f;
    public float up_Thrust = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,up_Thrust,0));
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,forward_Thrust));
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
