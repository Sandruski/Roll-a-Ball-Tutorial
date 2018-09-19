using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region PUBLIC_VARIABLES
    public float speed;
    #endregion

    #region PRIVATE_VARIABLES
    private float horizontalAxis;
    private float verticalAxis;

    private Rigidbody rb; // variable to hold the reference
    #endregion

    #region UNITY_CALLBACKS
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // reference
    }

    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(horizontalAxis, 0.0f, verticalAxis);
        rb.AddForce(movement * speed);
    }
    #endregion
}
