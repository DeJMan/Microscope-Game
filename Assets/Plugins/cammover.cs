using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammover : MonoBehaviour
{
	public Transform target;
	public float speed = 1.0F;
	public int interpolationFramesCount = 45; // Number of frames to completely interpolate between the 2 positions
    int elapsedFrames = 0;
    
    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.Lerp(transform.position, target.position, fractionOfJourney);
		float interpolationRatio = (float)elapsedFrames / interpolationFramesCount;
        Vector3 interpolatedPosition = Vector3.Lerp(transform.position, target.position, interpolationRatio);
        elapsedFrames = (elapsedFrames + 1) % (interpolationFramesCount + 1);
    }
}
