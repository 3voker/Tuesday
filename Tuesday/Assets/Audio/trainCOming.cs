using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainCOming : MonoBehaviour {

    public GameObject train;
    public GameObject chara;
	// Use this for initialization
	void Start () {
		        train.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            train.SetActive(true);
            Destroy(this);
            
            
        }
    }
}
