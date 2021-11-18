using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour {
    public CharacterController controller;
    public Rigidbody rb;
    public BoxCollider playerCollider;
    public Transform cam;
    public float speed = 16.0f, turnSmoothTime = 0.1f, mashDelay = 0.01f, jumpForce = 4;
    float turnSmoothVelocity, mash, boostTimer;
    bool boosting, started, pressed;

    void Start() {
        playerCollider = gameObject.GetComponent<BoxCollider>();
        mash = mashDelay;
        boosting = false;
        boostTimer = 0;
    }

    void Update() {
        Jump();

        //Movement
        float horziontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horziontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f) {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }

        //Mash a key to run faster. No limit to how fast you mash, with potentially unlimited speed?
        if (Input.GetKeyDown(KeyCode.Z)) {
            boosting = true;
            boostTimer += speed * Time.deltaTime;

            pressed = true;
            mash += mashDelay;
        } else if (Input.GetKeyUp(KeyCode.Z)) {
            pressed = false;
        }

        if (mash <= 0) {
            speed = 16;
            boosting = false;
        } else {
            mash -= Time.deltaTime;
            speed = 16 + mash;
        }
    }

    private void Jump() {
        bool jumpKeyPressed = Input.GetKeyDown(KeyCode.Space);
        if (jumpKeyPressed && isGrounded()) {
            Vector3 jumpVector = Vector3.up * jumpForce;
            jumpVector.x = rb.velocity.x;
            jumpVector.z = rb.velocity.z;
            rb.velocity = jumpVector;
        }
    }

    private bool isGrounded() {
        bool isGrounded = Physics.Raycast(transform.position, -gameObject.transform.up, playerCollider.bounds.extents.y + 0.1f);
        return isGrounded;
    }
}
