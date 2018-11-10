using UnityEngine;
using System.Collections;

public class TriggerControl : MonoBehaviour {
    public AudioSource Cheering;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.tag=="Player")
        {
            Cheering.Play();
        }
    }
}
