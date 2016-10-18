using UnityEngine;
using System.Collections;

public class SoundBall : MonoBehaviour
{

    private float soundBallSpeed = 0.2f;
    bool upMove = true;
    float initTime;
    int increment = 0;

    // Use this for initialization
    void Start()
    {
        initTime = Time.time;
        // new WaitForSeconds(1);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (upMove == true)
        {
            //Rigidbody rb = GetComponent<Rigidbody>();
            //rb.velocity *= Mathf.Sin(Time.time-initTime)+1;
            Vector3 position = transform.position;
            position.y += soundBallSpeed * Time.deltaTime;
            transform.position = position;
            print(transform.position.y);
            if (transform.position.y >= 1.02)
            {
                upMove = false;
                return;
            }
        }


        else if (upMove == false)
        {
            //Rigidbody rb = GetComponent<Rigidbody>();
            //rb.velocity = Vector3.down * soundBallSpeed;
            Vector3 position = transform.position;
            position.y += soundBallSpeed * Time.deltaTime * -1;

            transform.position = position;
            if (transform.position.y <= .95)
            {
                upMove = true;
                return;
            }
        }

        if (Input.GetButtonDown("Fire1") && increment == 0)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            audio.Play(44100);
        }


        /*
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            audio.Play(44100);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Stop();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // transform.position = transform.position;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.right * soundBallSpeed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // transform.position = transform.position;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.left * soundBallSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0,0,0);
        }
        */

    }
}
