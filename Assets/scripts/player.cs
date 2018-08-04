using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class player : MonoBehaviour {

    public float flashSpeed = 2f;
    public float speed = 5f;
    public float gravity = 5f;
    public float health = 100f;
    public Slider myslider;
    public Image myimage;

    private Collider mycollider;
    private float timer;
    private Transform mytransform;
    private AudioSource audio;
    private Light light;
    private bool darking = true;
    private Rigidbody rg;
	// Use this for initialization
	void Start () {
        timer = 0f;
        mycollider = GetComponent<Collider>();
        mycollider.enabled = true;
        myimage.color = Color.black;
        light = GetComponent<Light>();
        rg = GetComponent<Rigidbody>();
        Physics.gravity = new Vector3(0f, -gravity, 0f);
        audio = GetComponent<AudioSource>();
        mytransform = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer <=  2)
        {
            myimage.color = Color.Lerp(myimage.color, Color.clear, 1f * Time.deltaTime);
        }
        else
        {
            myimage.color = Color.clear;
            if (health > 0)
            {
                flash();
                move();
                myslider.value = health;
            }

            if (timer >= 10f)
            {
                health -= 4 * Time.deltaTime;
                if (health <= 0)
                {
                    mycollider.enabled = false;
                    health = 0;
                    myslider.value = health;
                    light.intensity = Mathf.LerpUnclamped(light.intensity, 0f, flashSpeed * Time.deltaTime);
                    if (light.intensity <= 0.1)
                    {
                        Destroy(this.gameObject);
                    }
                }
            }
        }
    }

    private void move()
    {
        //for computer
        if (Input.touchCount>0)
        {
            rg.AddForce(new Vector3(0f, speed/5f, 0f));
        }
    }

    private void flash()
    {
        if (darking)
        {
            light.intensity = Mathf.LerpUnclamped(light.intensity, 5f, flashSpeed * Time.deltaTime);
            if (light.intensity <= 5.6)
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

    private void OnTriggerEnter(Collider other)
    {
        if (health > 0){
            if (other.CompareTag("smallpickup"))
            {
                health += 10;
            }
            if (other.CompareTag("mediumpickup"))
            {
                health += 20;
            }
            if (other.CompareTag("largepickup"))
            {
                health += 30;
            }
            if (other.CompareTag("redbomb"))
            {
                health -= 20;
            }
            if (health > 100)
            {
                health = 100;
            }
            if (health < 0)
            {
                health = 0;
            }
        }    
    }

}
