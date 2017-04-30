using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class vrwalk : MonoBehaviour {
    public float speed = 3.0f;
    public bool moveForward;
    private CharacterController controller;
    private Transform vrHead;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
