using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseRotation : MonoBehaviour {

	public float sensitivity;
	private bool FlipY = true;

	void Update () {
		
		if(Input.GetMouseButton(1)){
		var mousepos = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y") * (FlipY ? -1 : 1) );
		
		transform.Rotate (mousepos.y * sensitivity,  mousepos.x * sensitivity, 0);
		transform.eulerAngles=new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,0);

	}

	}
}


