using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Limits
{
    public float min;
    public float max;

    public Limits(float _min,float _max)
    {
        min = _min;
        max = _max;
    }
}

public class movement : MonoBehaviour
{
	public float speed = 10.0f;

    public Limits horizontalLimits;
    public Limits verticalLimits;

    // Update is called once per frame
    void Update()
    {
        float up = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float side = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        float newX = Mathf.Clamp(transform.position.x - side, horizontalLimits.min, horizontalLimits.max);
        float newY = Mathf.Clamp(transform.position.y + up, verticalLimits.min, verticalLimits.max);

        transform.position = new Vector3(newX, newY, transform.position.z);
    }
}
