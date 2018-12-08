using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private bool doMovement = true;

	public float panSpeed = 30f;
	public float panBoarderThickness = 10f;
	public float scrollSpeed = 5f;
	public float minY = 10f;
	public float maxY = 80f;
	
	// Update is called once per frame
	void Update () {
		
		if (GameManager.gameEnded)
		{
			this.enabled = false;
			return;
		}
		
		
		if (Input.GetKey("d") || Input.mousePosition.y >= Screen.height - panBoarderThickness )
		{
			transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
		}
		
		if (Input.GetKey("a") || Input.mousePosition.y <= panBoarderThickness )
		{
			transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
		}
		
		if (Input.GetKey("s") || Input.mousePosition.x >= Screen.width - panBoarderThickness )
		{
			transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
		}
		
		if (Input.GetKey("w") || Input.mousePosition.x <= panBoarderThickness )
		{
			transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
		}
		//Zoom in and out
		float scroll = Input.GetAxis("Mouse ScrollWheel");
		
		Vector3 pos = transform.position;
		
		pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
		pos.y = Mathf.Clamp (pos.y, minY, maxY);
		
		
		transform.position = pos;
		
	}
}
