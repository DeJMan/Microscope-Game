using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        
		if(other.tag == "dj")
		{
			Debug.Log(other);
		}
    }
	
}
