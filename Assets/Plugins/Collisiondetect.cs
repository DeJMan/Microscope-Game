using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondetect : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
    {        
		if(other.tag == "dj")
		{
			Debug.Log(other);
		}
    }	
}
