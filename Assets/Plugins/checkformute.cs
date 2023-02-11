using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkformute : MonoBehaviour
{
	AudioSource asrc;
	public int mute = 0;
    // Start is called before the first frame update
    void Start()
    {
		asrc = GetComponent<AudioSource>();
        if(PlayerPrefs.HasKey("mute"))
		{
			mute = PlayerPrefs.GetInt("mute");
			if(mute == 1)
			{
				asrc.mute = true;
			}
		}
		asrc.Play();
	}
	
}
