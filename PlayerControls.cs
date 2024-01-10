using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float originalThrustSpeed;
    public float thrustSpeed;
    public float turnSpeed;

    public float hoverPower;
    public float hoverHeight;

    private float thrustInput;
    private float turnInput;
    private Rigidbody shipRigidBody;


    void Start()
    {
        originalThrustSpeed = thrustSpeed;
        shipRigidBody = GetComponent<Rigidbody>();
    } //start

    
    void Update()
    {
        thrustInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");

        //Turbo
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            thrustSpeed = originalThrustSpeed * 3f;
        } //if

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            thrustSpeed = originalThrustSpeed;
        } //if

        // ESC quits application
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        } //if
    } //update

    void FixedUpdate()
    {
        // Turning the ship
        shipRigidBody.AddRelativeTorque(0f, turnInput * turnSpeed, 0f);

        // Moving the ship
        shipRigidBody.AddRelativeForce(0f, 0f, thrustInput * thrustSpeed);

        // Hovering
        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, hoverHeight))
        {
            float proportionalHeight = (hoverHeight - hit.distance) / hoverHeight;
            Vector3 appliedHoverForce = Vector3.up * proportionalHeight * hoverPower;
            shipRigidBody.AddForce(appliedHoverForce, ForceMode.Acceleration);
        } //if
    } //fixedupdate
} //class
