using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public float sensitivity;

    private Rigidbody rb;
    private Transform cam;
    private Vector3 playerMovementInput;
    private Vector2 playerMouseInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        playerMouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        MovePlayer();
        MoveCamera();
    }

    /// <summary>
    /// Controls the players movement and jump functions
    /// Jump programmed by adding force to rigid body when space is pressed
    /// Movement implemented by changed rb velocity to playerMovementInput*speed
    /// </summary>
    public void MovePlayer()
    {
        Vector3 moveVector = transform.TransformDirection(playerMovementInput) * speed * Time.deltaTime;
        rb.velocity = new Vector3(moveVector.x, rb.velocity.y, moveVector.z);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void MoveCamera()
    {

    }

}
