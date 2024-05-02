using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public float sensitivity;
    public Transform cam;
    public float HP;
    public Transform gun;

    private Rigidbody rb;
    private float xRot;
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
        Shoot();
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
        //transform.Rotate(cam.rotation.x, 0f , 0f);

        if(Input.GetKeyDown(KeyCode.Space) && OnGround())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void MoveCamera()
    {
        xRot -= playerMouseInput.y * sensitivity;

        transform.Rotate(0f, playerMouseInput.x * sensitivity, 0f);
        cam.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
    }

    public void Shoot()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            RaycastHit hit;
            bool hitZombie;
            Debug.DrawRay(cam.transform.position, cam.transform.forward, Color.red);
            if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 300f))
            {
                if(hit.collider.tag == "Zombie")
                {
                    Destroy(hit.collider.gameObject);
                }
                    
            }
        }
    }

    public void GameOver()
    {
        if(HP <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<HealthPack>())
        {
            HP += other.gameObject.GetComponent<HealthPack>().healthRestored;
            Destroy(other.gameObject);
        }
    }

    private bool OnGround()
    {
        bool hitGround = false;
        RaycastHit hit;

        if(Physics.Raycast(transform.position, Vector3.down, out hit, 1.5f))
        {
            hitGround = true;
        }

        return hitGround;
    }

}
