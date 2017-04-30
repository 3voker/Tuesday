using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforwardsuic : MonoBehaviour {
        public int speed;
	// Use this for initialization
	void Start () {
        speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition += transform.forward * speed * Time.deltaTime;
    }
}
