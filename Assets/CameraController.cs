using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject cameraDock = null;
    public float speed = 1.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector3.Lerp(transform.position, cameraDock.transform.position, Time.deltaTime * speed);
	}
}
