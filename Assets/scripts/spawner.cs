using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour {
    public GameObject smallpickup;
    public GameObject mediumpickup;
    public GameObject largepickup;
    public GameObject redbomb;

    public Slider myslider;
    public float spawnTime = 2f;

    private float timer;

	// Use this for initialization
	void Start () {
        timer = 0f;
        InvokeRepeating("Spawn", 0, spawnTime);
    }

    void Update()
    {
        timer += Time.deltaTime; 
    }

    void Spawn()
    {
        if(timer<60)
        {
            int index = Random.Range(0, 100);
            if (index <= 30)
            {
                Vector3 position = new Vector3(0.5f, Random.Range(6f, 14f), 10.5f + index / 30f);
                Instantiate(smallpickup, position, smallpickup.transform.rotation);
            }
            else if (index <= 50)
            {
                Vector3 position = new Vector3(0.5f, Random.Range(6f, 14f), 10.5f + index / 30f);
                Instantiate(mediumpickup, position, mediumpickup.transform.rotation);
            }
            else if (index <= 65)
            {
                Vector3 position = new Vector3(0.5f, Random.Range(6f, 14f), 10.5f + index / 30f);
                Instantiate(largepickup, position, largepickup.transform.rotation);
            }
            else if (index <= 100)
            {
                Vector3 position = new Vector3(0.5f, Random.Range(6f, 14f), 10.5f + index / 30f);
                Instantiate(redbomb, position, redbomb.transform.rotation);
            }
        }
        else if((timer < 110))
        {
            int index = Random.Range(0, 100);
            if (index <= 25)
            {
                Vector3 position = new Vector3(0.5f, Random.Range(6f, 14f), 10.5f + index / 30f);
                Instantiate(smallpickup, position, smallpickup.transform.rotation);
            }
            else if (index <= 40)
            {
                Vector3 position = new Vector3(0.5f, Random.Range(6f, 14f), 10.5f + index / 30f);
                Instantiate(mediumpickup, position, mediumpickup.transform.rotation);
            }
            else if (index <= 50)
            {
                Vector3 position = new Vector3(0.5f, Random.Range(6f, 14f), 10.5f + index / 30f);
                Instantiate(largepickup, position, largepickup.transform.rotation);
            }
            else if (index <= 100)
            {
                Vector3 position = new Vector3(0.5f, Random.Range(6f, 14f), 10.5f + index / 30f);
                Instantiate(redbomb, position, redbomb.transform.rotation);
            }
        }
        else
        {
            int index = Random.Range(0, 100);
            if (index <= 15)
            {
                Vector3 position = new Vector3(0.5f, Random.Range(6f, 14f), 10.5f + index / 30f);
                Instantiate(smallpickup, position, smallpickup.transform.rotation);
            }
            else if (index <= 35)
            {
                Vector3 position = new Vector3(0.5f, Random.Range(6f, 14f), 10.5f + index / 30f);
                Instantiate(mediumpickup, position, mediumpickup.transform.rotation);
            }
            else if (index <= 40)
            {
                Vector3 position = new Vector3(0.5f, Random.Range(6f, 14f), 10.5f + index / 30f);
                Instantiate(largepickup, position, largepickup.transform.rotation);
            }
            else if (index <= 100)
            {
                Vector3 position = new Vector3(0.5f, Random.Range(6f, 14f), 10.5f + index / 30f);
                Instantiate(redbomb, position, redbomb.transform.rotation);
            }
        }
        
       

    }

}
