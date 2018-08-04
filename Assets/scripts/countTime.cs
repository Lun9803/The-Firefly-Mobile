using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class countTime : MonoBehaviour {

    public Text mytext;
    public GameObject player;

    private int best;
    private float timer;
    private string datapath;
	// Use this for initialization
	void Start () {
        best = PlayerPrefs.GetInt("best");
        timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (player)
        {
            timer += Time.deltaTime;
            if (timer >= 10)
            {
                mytext.text = "时间: " + ((int)(timer - 10)).ToString();
            }
            if (timer-10 > best)
            {
                PlayerPrefs.SetInt("best", (int)timer - 10);
            }
        }
    }
}
