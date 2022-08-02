using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumper : MonoBehaviour
{
    public float force = 10f;
    public int experience = 0;

    public Animator anim;

    public bool isGrounded;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (experience > 10)
        {
            force = force * 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * force;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * force;

        transform.Translate(horizontal, 0, vertical);

        Jump();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            anim.SetBool("Jumping", false);
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            anim.SetBool("Jumping", true);
            rb.AddForce(new Vector3(0f, 5f, 0f) * force, ForceMode.Impulse);
            isGrounded = false;

            experience = experience + 2;
        }
    }
}