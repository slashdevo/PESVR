using UnityEngine;
using System.Collections;

public class RotateCopter : MonoBehaviour {
    public int RotationSpeed=50;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0,30,0) * RotationSpeed * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponentInParent<Animator>().enabled = true;
        }
	}
}
