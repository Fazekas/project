using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
	public float horizontalSpeed;
	private Vector3 rotation;
    
    void Start()
    {
        offset = transform.position - player.transform.position;

		rotation = new Vector3(0, offset.y, offset.z);
    }
    
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;   

		rotation = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * horizontalSpeed, Vector3.up) * rotation;

		transform.position = player.transform.position + rotation;
		transform.LookAt(player.transform.position);

	}
		
}
