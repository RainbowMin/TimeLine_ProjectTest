using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public float MoveSpeed = 10f;
    public GameObject Object;
    
    // Update is called once per frame
	void Update ()
    {
	    if(Input.GetKey(KeyCode.W))
        {
            Object.transform.position += new Vector3(MoveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Object.transform.position += new Vector3(-1 * MoveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Object.transform.position += new Vector3(0, 0, MoveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Object.transform.position += new Vector3(0, 0, MoveSpeed * Time.deltaTime * -1);
        }
    }
}
