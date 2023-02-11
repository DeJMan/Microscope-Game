using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugChooser : MonoBehaviour
{
	public GameObject one;
	public GameObject two;
	public GameObject tre;
    // Start is called before the first frame update
    void Start()
    {
        float aa = Random.Range(10f, 100.0f);
	if(aa <= 33f)
	{
		Destroy(two);
		Destroy(tre);
		}
	else if(aa >= 66)
	{
		Destroy(one);
		Destroy(tre);
		
		}
	else
	{
		Destroy(two);
		Destroy(one);
		
		}
    }

}
