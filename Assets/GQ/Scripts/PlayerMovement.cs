
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 1250f;
    public float sidewardForce = 750f;
     
    void FixedUpdate()
    {
        rb.AddForce(forwardForce*Time.deltaTime, 0, 0);

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sidewardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sidewardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
