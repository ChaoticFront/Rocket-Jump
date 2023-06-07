
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    [SerializeField] private float forwardForce = 1250f;
    [SerializeField] private float sidewardForce = 750f;
     
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
        if (rb.position.y < -5)
        {
            FindObjectOfType<GameManager> ().EndGame(); 
        }
    }
}
