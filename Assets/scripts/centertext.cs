using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class centertext : MonoBehaviour {
    public GameObject player;
    public Text mytext;

    private int deadTime;
    private int startTime;
    private float timer;
    // Use this for initialization
    void Start()
    {
        timer = 0f;
        mytext.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer <= 12)
        {
            mytext.color = Color.Lerp(mytext.color, Color.white, 0.5f * Time.deltaTime);
        }
        else if (timer < 16)
        {
            mytext.color = Color.Lerp(mytext.color, Color.clear, 1.5f * Time.deltaTime);
        }
        //difficulty lv up
        else if(timer > 60 && timer <= 70)
        {
            mytext.text = "越来越危险了...";
            mytext.color = Color.Lerp(mytext.color, Color.white, 0.7f * Time.deltaTime);
        }
        else if (timer > 70 && timer < 75)
        {
            mytext.color = Color.Lerp(mytext.color, Color.clear, 1.5f * Time.deltaTime);
        }
        else if (timer > 110 && timer <= 120)
        {
            mytext.text = "还可以走多久呢...";
            mytext.color = Color.Lerp(mytext.color, Color.white, 0.7f * Time.deltaTime);
        }
        else if (timer > 120 && timer < 125)
        {
            mytext.color = Color.Lerp(mytext.color, Color.clear, 1.5f * Time.deltaTime);
        }


        if (!player)
        {
            mytext.text = "嘿，别担心，我们可以再来过\r\n我想你知道怎么重新开始";
            mytext.color = Color.Lerp(mytext.color, Color.white, 0.5f * Time.deltaTime);
            
            if (Input.touchCount > 0 && timer>deadTime+5.5f) 
            {
                SceneManager.LoadScene("TheFirefly");
            }
        }
        else
        {
            deadTime = (int)timer;
        }
    }
}
