using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public Rigidbody rb;
    public float swingForceMultiplier = 10f;

    private Vector3 previousPosition;

    void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody>();

        previousPosition = transform.position;
    }

    void FixedUpdate()
    {
        Vector3 velocity = (transform.position - previousPosition) / Time.fixedDeltaTime;
        rb.velocity = velocity;
        previousPosition = transform.position;
    }
}