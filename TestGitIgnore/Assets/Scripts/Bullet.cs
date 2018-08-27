using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    Rigidbody bullet;
	// Use this for initialization
	void Start () {
        bullet = GetComponent<Rigidbody>();
        Vector3 ajustedMovement = transform.TransformDirection(Vector3.forward);
        bullet.AddForce(ajustedMovement * 1000);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
