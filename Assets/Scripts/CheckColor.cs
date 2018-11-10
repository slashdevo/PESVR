using UnityEngine;
using System.Collections;

public class CheckColor : MonoBehaviour {
    
    
    // Use this for initialization
    IEnumerator Start () {

        yield return new WaitForSeconds(103);
        Application.LoadLevel("StartScene");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
