using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start() 
    {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() 
    {
        RocketThrust();
        RocketPivot();
    }

    // Pivots the rocket clockwise and anti-clockwise
    void RocketPivot()
    {
        if (Input.GetKey("a")) {
            transform.Rotate(Vector3.forward);
        } else if (Input.GetKey("d")) {
            transform.Rotate(-Vector3.forward);
        }
    }

    // Propels the rocket forward
    void RocketThrust() 
    {
        if (Input.GetKey(KeyCode.Space)) {
                    rigidBody.AddRelativeForce(Vector3.up);

            if (!audioSource.isPlaying) {
                audioSource.Play();
            }
        } else {
            audioSource.Stop();
        }
}
}
