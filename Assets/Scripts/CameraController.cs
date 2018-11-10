using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public GameObject MainCam, WghiteCam, BlackCam, GeneralCam;
    public GameObject MainCam1, WghiteCam1, BlackCam1, GeneralCam1;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            MainCam.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GeneralCam.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            WghiteCam.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            BlackCam.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            MainCam1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            GeneralCam1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            WghiteCam1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            BlackCam1.SetActive(true);
        }
    }
}
