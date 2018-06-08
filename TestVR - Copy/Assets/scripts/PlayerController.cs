using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

   

    private Vector3 direction;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
       
        transform.position += Time.deltaTime * Camera.main.transform.forward * 2.5f;
        transform.position = new Vector3(transform.position.x, -0.5f, transform.position.z);
           
        
        
		
	}
}
