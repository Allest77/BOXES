using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdPersonMovement : MonoBehaviour {
    public CharacterController controller;
    public Rigidbody rb;
    public BoxCollider playerCollider, deliverCollider;
    public Transform cam;
    public float speed = 12.0f, turnSmoothTime = 0.1f, mashDelay = 0.001f, jumpForce = 4, distance, threshold = 56;
    float turnSmoothVelocity, mash, boostTimer;
    bool boosting, started, pressed, putDown = false;
    public GameObject dropOff, packageSpawn;
    private pkgSpawnManager nextStop, stopAmount;
    public Text stop;
    public int packageNumber;

    void Start() {
        nextStop = packageSpawn.GetComponent<pkgSpawnManager>();

        packageNumber = nextStop.stopAmount;
        Debug.Log(packageNumber);

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
            speed = 12;
            boosting = false;
        } else {
            mash -= Time.deltaTime;
            speed = 12 + mash;
        }

        if (Input.GetKeyDown(KeyCode.X) && putDown) {
            nextStop.SpawnRandomPackage();
            packageNumber -= 1;
            stop.text = "stops: " + packageNumber.ToString();
            Debug.Log("Dropped off");
        }

        distance = Vector3.Distance(dropOff.transform.position, transform.position); //makes a float value based on the distance.
    }

    void OnTriggerEnter(Collider deliverCollider) {
        putDown = true;
    }

    private void OnTriggerExit(Collider other) {
        putDown = false;
    }

    private bool isGrounded() {
        bool isGrounded = Physics.Raycast(transform.position, -gameObject.transform.up, playerCollider.bounds.extents.y + 0.1f);
        return isGrounded;
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
}
