using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walker : MonoBehaviour {

    // Use this for initialization

    private bool walking = false;
    private Vector3 SpawnPoint;
	void Start () {

        SpawnPoint = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (walking)
        {
            transform.position = transform.position + Camera.main.transform.forward * 1f * Time.deltaTime;
        }

        if (transform.position.y <= -10f)
        {
            transform.position = SpawnPoint;
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(h, v, 0));


        RaycastHit Hit;


        if (Input.GetButtonDown("Fire1"))
        {
            walking = true;
        }

        if (Physics.Raycast (ray, out Hit))
        {



            if (Hit.collider.name.Contains("plane"))
            {
                walking = false;

            }

            else { walking = true; }
        }
    }
}
