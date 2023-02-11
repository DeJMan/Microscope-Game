using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public float speed = 10.0f;
	
    // Update is called once per frame
    void Update()
    {
		float up = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float side = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		
        transform.Translate(-side, up, 0);
    }
}
