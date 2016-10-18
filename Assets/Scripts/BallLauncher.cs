using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

    public GameObject Ball;
    public float ballSpeed = 5.0f;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            GameObject instance = Instantiate(Ball);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * ballSpeed;
        }


    }
}
