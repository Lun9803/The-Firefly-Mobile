using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largepickup : MonoBehaviour {

    public float flashSpeed = 2f;
    public float moveSpeed = 1f;
    public float horizontalSpeed = 1f;

    private Light light;
    private bool darking = true;
    private bool down = true;
    private bool colliding = false;
    private Rigidbody rg;
    private SphereCollider collider;
    private float startpoint;
    private AudioSource audio;
    // Use this for initialization
    void Start()
    {
        light = GetComponent<Light>();
        rg = GetComponent<Rigidbody>();
        startpoint = transform.position.y;
        collider = GetComponent<SphereCollider>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        flash();
        move();
        if (transform.position.z <= -15)
        {
            Destroy(this.gameObject);
        }
    }

    private void move()
    {
        transform.Translate(Vector3.back * Time.deltaTime * horizontalSpeed);

        if (down)
        {
            rg.AddForce(new Vector3(0f, -moveSpeed, 0f));
            if (transform.position.y <= (startpoint - collider.radius / 2f))
            {
                down = false;
            }
        }
        else
        {
            rg.AddForce(new Vector3(0f, moveSpeed, 0f));
            if (transform.position.y >= startpoint)
            {
                down = true;
            }
        }


    }

    private void flash()
    {
        if (!colliding)
        {
            if (darking)
            {
                light.intensity = Mathf.LerpUnclamped(light.intensity, 5f, flashSpeed * Time.deltaTime);
                if (light.intensity <= 5.1)
                {
                    darking = false;
                }
            }
            else
            {
                light.intensity = Mathf.LerpUnclamped(light.intensity, 10f, flashSpeed * Time.deltaTime);
                if (light.intensity >= 9.9)
                {
                    darking = true;
                }
            }
        }
        else
        {
            light.intensity = Mathf.LerpUnclamped(light.intensity, 0, 0.5f * flashSpeed * Time.deltaTime);
            if (light.intensity <= 0)
            {
                Destroy(this.gameObject);
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            audio.Play();
            colliding = true;
            collider.enabled = false;
        }
    }
}
