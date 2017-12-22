using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public Transform cam;

    public float speed = 5;

	void Start () {
		
	}
	
	void LateUpdate ()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");

        Vector3 forward = cam.forward;
        forward.y = 0;

        //根据镜头旋转确定移动方向
        Vector3 movement = (forward * inputV + cam.right * inputH) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
