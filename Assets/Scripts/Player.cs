using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int score;
    public float power;
    public float modifier;
    public float nextRotation;
    public float timeMod;
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        Time.timeScale = timeMod;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
        {
            power++;
        }

        if (Input.GetMouseButtonUp(0))
        {
            rb.AddForce(new Vector3(-power*modifier,power*modifier,0));
            power = 0;
        }
	}
}
