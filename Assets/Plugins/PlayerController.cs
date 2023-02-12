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

public class PlayerController : MonoBehaviour
{
	public float speed = 10.0f;

    public Limits horizontalLimits;
    public Limits verticalLimits;

    Vector3 targetPosition;

    [Header("Shatter Specific")]
    public List<Rigidbody> scopeParts;
    public Rigidbody dejman;
    public float explosionForce;
    public float upwardsModifier;

    bool canMove = true;

    public static PlayerController instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
            return;

        ProcessMovement();
    }

    void ProcessMovement()
    {
        float up = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float side = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        float newX = Mathf.Clamp(transform.position.x - side, horizontalLimits.min, horizontalLimits.max);
        float newY = Mathf.Clamp(transform.position.y + up, verticalLimits.min, verticalLimits.max);

        targetPosition.x = newX;
        targetPosition.y = newY;

        transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
    }

    public void Shatter()
    {
        canMove = false;
        StopAllCoroutines();
        StartCoroutine(DoShatterSequence());
    }

    IEnumerator DoShatterSequence()
    {
        for (int i = 0; i < scopeParts.Count; i++)
        {
            scopeParts[i].isKinematic = false;
            scopeParts[i].AddExplosionForce(explosionForce, dejman.worldCenterOfMass, 4f, upwardsModifier, ForceMode.VelocityChange);
            scopeParts[i].AddTorque(Random.insideUnitSphere*1f, ForceMode.VelocityChange);
        }

        dejman.isKinematic = false;
        dejman.useGravity = true;
        dejman.AddExplosionForce(explosionForce, dejman.worldCenterOfMass, 4f, upwardsModifier, ForceMode.VelocityChange);
        dejman.AddTorque(Random.insideUnitSphere * 1f, ForceMode.VelocityChange);

        yield return new WaitForSeconds(3f);

        GameManager.instance.EndGame();
    }
}
