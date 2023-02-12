using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulb : MonoBehaviour
{
	public Transform BulbMesh;
    public float speed = 1f;
	public float flyspeed = 0.1f;
	public GameManager s;
	public lookat l;
	public GameObject pref;
	public GameObject bloop;
	
	void Start()
	{
		GameObject go = GameObject.FindWithTag("manager");
		s = go.GetComponent<GameManager>();
		GameObject gs = GameObject.FindWithTag("looker");
		l = gs.GetComponent<lookat>();
	}
	
    // Update is called once per frame
    void Update()
    {
        BulbMesh.RotateAround(BulbMesh.position, Vector3.up, 20 * Time.deltaTime * speed);
		transform.Translate(0, 0, flyspeed * 0.1f);
		if(transform.position.z > 50f)
		{
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter(Collider other)
    {        
		if(other.tag == "dj")
		{
			s.Scoreincrease();
			l.lookatcam();
			GameObject a = Instantiate(pref, transform.position, Quaternion.identity);
			GameObject b = Instantiate(bloop, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}
}
