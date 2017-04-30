using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class walk : MonoBehaviour {


    private Transform vrhead;
    private CharacterController cc;
	// Use this for initialization
	void Start () {

        vrhead = Camera.main.transform;
        cc = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 forward = vrhead.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * 0.1f);
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //float xx = Input.GetButtonDown("Mouse Scrollwj");
        //float yy = Input.GetAxis("Vertical");



        transform.position += new Vector3(h * 0.1f, 0f, v* 0.1f);
		
	}
}
