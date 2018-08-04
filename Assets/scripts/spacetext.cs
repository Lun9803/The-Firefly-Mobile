using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class spacetext : MonoBehaviour {

    public Text mytext;
    public Image fadeimage;

    private bool isStart;
    private bool lighting;
    private int startTime;
	// Use this for initialization
	void Start () {
        lighting = true;
        isStart = false;
        mytext.color = new Color(1, 1, 1, 0.5f);
        fadeimage.color = Color.clear;
        startTime = (int)Time.realtimeSinceStartup;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount>0 && Time.realtimeSinceStartup>startTime+4)
        {
            isStart = true;
        }
        if (!isStart)
        {
            if(lighting)
        {
                mytext.color = Color.Lerp(mytext.color, Color.white, 5f * Time.deltaTime);
                if (mytext.color == Color.white)
                {
                    lighting = false;
                }
            }
            else
            {
                mytext.color = Color.Lerp(mytext.color, new Color(1, 1, 1, 0.5f), 5f * Time.deltaTime);
                if (mytext.color == new Color(1, 1, 1, 0.5f))
                {
                    lighting = true;
                }
            }
        }
        else
        {
            fadeimage.color = Color.Lerp(fadeimage.color, Color.black, 3f * Time.deltaTime);
            if (fadeimage.color == Color.black)
            {
                SceneManager.LoadScene("TheFirefly");
            }
        }
    }
}
