using UnityEngine;

public class PedestrianMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as per your requirements

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rb.velocity = movement * speed;
    }
}
