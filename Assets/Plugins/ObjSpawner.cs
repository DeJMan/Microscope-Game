using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawner : MonoBehaviour
{
	public GameObject Bug;
	public GameObject Lightb;
	
	public int counter = 1000;
	public int maxcounter = 1000;
	
	public int Durationcounter = 1;
	public float varspeed;
	
	public void Start()
    {
        counter = maxcounter;
		if(varspeed < 0.3f)
		{
			
			varspeed += 0.3f;
		}
		createnew();
	}
	
    public void rundowncounter()
    {
		counter--;
		if(counter <= 0)
		{
			maxcounter -= 20;
			if(maxcounter <= 10)
			{
				maxcounter = 10;
			}
			counter = maxcounter;
			Durationcounter++;
			varspeed = Durationcounter/50f;
			if(varspeed < 0.3f)
			{
				
				varspeed += 0.3f;
			}
			createnew();
		}
	}
	
    // Update is called once per frame
    public void Update()
    {
        rundowncounter();
	}
	
	public void createnew()
	{
		float r = Random.Range(1f, 100f);
		var position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), -100f);
		if(r <= 50f)
		{
			GameObject a = Instantiate(Bug, position, Quaternion.identity);
			Bug bug = a.GetComponent<Bug>();
			bug.flyspeed = varspeed;
		}
		else
		{
			GameObject a = Instantiate(Lightb, position, Quaternion.identity);
			Bulb bulb = a.GetComponent<Bulb>();
			bulb.flyspeed = varspeed;
		}
	}
}
