using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region PUBLIC_VARIABLES
    public GameObject player;
    #endregion

    #region PRIVATE_VARIABLES
    private Vector3 offset;
    #endregion

    void Start()
    {
        offset = transform.position - player.transform.position;
	}
	
	void LateUpdate()
    {
        transform.position = player.transform.position + offset;
	}
}
