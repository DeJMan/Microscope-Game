using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{
	public Transform target;
	public Transform forwardtarget;
	public Transform camera;
	public Transform head;
	public Transform headwithrenderer;
	public float timeCount = 0.0f;
	
	public Texture hapi;
	public Texture angri;
	
	Renderer m_Renderer;
    // Start is called before the first frame update
    void Start()
    {
        target = forwardtarget;
		//Fetch the Renderer from the GameObject
        m_Renderer = headwithrenderer.GetComponent<Renderer> ();
        //Set the Texture you assign in the Inspector as the main texture (Or Albedo)
		m_Renderer.material.mainTexture = hapi;		
	}
	
    // Update is called once per frame
    void Update()
    {
		if(target != null)
		{
			transform.LookAt(target, Vector3.up);
		}
		
		head.rotation = Quaternion.Slerp(transform.rotation, target.rotation, timeCount);
        timeCount = timeCount + Time.deltaTime;
	}
	
	public void lookatcam()
	{
		m_Renderer.material.mainTexture = hapi;
		StartCoroutine(ExampleCoroutine());
	}
	
	public void lookatcamangri()
	{
		m_Renderer.material.mainTexture = angri;
		StartCoroutine(ExampleCoroutine2());
	}
	IEnumerator ExampleCoroutine()
    {		
        target = camera;
		
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);
		
        target = forwardtarget;
	}
	
	IEnumerator ExampleCoroutine2()
    {
        target = camera;
		
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3);
		
        target = forwardtarget;
	}
	
}
