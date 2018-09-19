using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    #region PUBLIC_VARIABLES
    public float speed;

    public Text countText;
    public Text winText;
    #endregion

    #region PRIVATE_VARIABLES
    private int count;

    private float horizontalAxis;
    private float verticalAxis;

    private Rigidbody rb; // variable to hold the reference
    #endregion

    #region UNITY_CALLBACKS
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // reference

        count = 0;
        SetCountText();

        winText.text = ""; // empty string
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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            count++;
            SetCountText();

            other.gameObject.SetActive(false);
            //Destroy(other.gameObject); // remove the other gameObject from the scene
        }
    }
    #endregion

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 12)
            winText.text = "You Win!";
    }
}
