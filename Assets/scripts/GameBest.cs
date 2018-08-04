using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBest : MonoBehaviour {

    public Text mytext;
	// Use this for initialization
	void Start () {
        if (!PlayerPrefs.HasKey("best"))
        {
            PlayerPrefs.SetInt("best", 0);
        }
        mytext.text = "最高记录：" + PlayerPrefs.GetInt("best");
	}
	
	// Update is called once per frame
	void Update () {
        mytext.text = "最高记录：" + PlayerPrefs.GetInt("best");
    }
}
