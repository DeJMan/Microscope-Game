using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playclick : MonoBehaviour
{
	public GameObject bloop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void playclicksound()
    {
        GameObject c = Instantiate(bloop, transform.position, Quaternion.identity);
    }
}
