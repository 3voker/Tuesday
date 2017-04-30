using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    public float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        transform.localPosition += (transform.forward * -1)* speed * Time.deltaTime; // or transform.position, both would work

    }
}
