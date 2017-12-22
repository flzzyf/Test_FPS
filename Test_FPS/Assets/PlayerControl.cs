using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public GameObject currentWeapon;

	void Start () {
		
	}
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentWeapon.GetComponent<Animator>().Play("Machete_Attack");
        }
	}
}
