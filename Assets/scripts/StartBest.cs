using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartBest : MonoBehaviour {

    public Text mytext;
	// Use this for initialization
	void Start () {
        if (!PlayerPrefs.HasKey("best"))
        {
            PlayerPrefs.SetInt("best", 0);
        }
        mytext.text = "最高纪录：" + ((int)PlayerPrefs.GetInt("best")).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
