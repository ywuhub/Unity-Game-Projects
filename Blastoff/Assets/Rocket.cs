using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    AudioSource audioSource;

    [SerializeField] float rcsThrust = 100f;
    [SerializeField] float mainThrust = 10f;

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

    // When rocket collides onto objects
    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case ("Friendly"):
                // ToDo: Do nothing as rocket hits friendly object
                print("Hit Friendly Object");
                break;
            case ("Fuel"):
                // ToDo: Add fuel for the rocket
                break;
            default:
                print("Dead!");
                // ToDo: Lose Game
                break;
        }
    }

    // Propels the rocket forward
    void RocketThrust() 
    {
        if (Input.GetKey(KeyCode.Space)) {

            rigidBody.AddRelativeForce(Vector3.up * mainThrust);

            if (!audioSource.isPlaying) {
                audioSource.Play();
            }
        } else {
            audioSource.Stop();
        }
    }

    // Pivots the rocket clockwise and anti-clockwise
    void RocketPivot()
    {
        rigidBody.freezeRotation = true; // take manual control of rotation

        float rotationCurrFrame = rcsThrust * Time.deltaTime;

        if (Input.GetKey("a")) {
            transform.Rotate(Vector3.forward * rotationCurrFrame);
        } else if (Input.GetKey("d")) {
            transform.Rotate(-Vector3.forward * rotationCurrFrame);
        }

        rigidBody.freezeRotation = false; // resume physics control of rotation
    }

    
}
