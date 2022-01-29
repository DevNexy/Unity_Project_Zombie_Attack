using UnityEngine;
using System.Collections;


public class MouseLookScript : MonoBehaviour {

	public Transform myCamera;
	
	void Awake(){
		Cursor.lockState = CursorLockMode.Locked;
		myCamera = GameObject.FindGameObjectWithTag("MainCamera").transform;
	}
	void  Update(){

		MouseInputMovement();

		if (Input.GetKeyDown (KeyCode.L)) {
			Cursor.lockState = CursorLockMode.Locked;

		}
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;

		if(GetComponent<PlayerMovementScript>().currentSpeed > 1)
			HeadMovement ();

	}

	public float timer;
	public int int_timer;
	public float zRotation;
	public float wantedZ;
	public float timeSpeed = 2;

	public float timerToRotateZ;
	
	void HeadMovement(){
		timer += timeSpeed * Time.deltaTime;
		int_timer = Mathf.RoundToInt (timer);
		if (int_timer % 2 == 0) {
			wantedZ = -1;
		} else {
			wantedZ = 1;
		}

		zRotation = Mathf.Lerp (zRotation, wantedZ, Time.deltaTime * timerToRotateZ);
	} 
	public float mouseSensitvity = 0;

	public float mouseSensitvity_notAiming = 300;

	public float mouseSensitvity_aiming = 50;

void FixedUpdate(){

	
	if(Input.GetAxis("Fire2") != 0){
		mouseSensitvity = mouseSensitvity_aiming;
	}
	else if(GetComponent<PlayerMovementScript>().maxSpeed > 5){
		mouseSensitvity = mouseSensitvity_notAiming;
	}
	else{
		mouseSensitvity = mouseSensitvity_notAiming;
	}
	ApplyingStuff();
}


private float rotationYVelocity, cameraXVelocity;

public float yRotationSpeed, xCameraSpeed;


public float wantedYRotation;

public float currentYRotation;

public float wantedCameraXRotation;

public float currentCameraXRotation;


public float topAngleView = 60;

public float bottomAngleView = -45;

void MouseInputMovement(){

	wantedYRotation += Input.GetAxis("Mouse X") * mouseSensitvity;

	wantedCameraXRotation -= Input.GetAxis("Mouse Y") * mouseSensitvity;

	wantedCameraXRotation = Mathf.Clamp(wantedCameraXRotation, bottomAngleView, topAngleView);

}


void ApplyingStuff(){

	currentYRotation = Mathf.SmoothDamp(currentYRotation, wantedYRotation, ref rotationYVelocity, yRotationSpeed);
	currentCameraXRotation = Mathf.SmoothDamp(currentCameraXRotation, wantedCameraXRotation, ref cameraXVelocity, xCameraSpeed);

	transform.rotation = Quaternion.Euler(0, currentYRotation, 0);
	myCamera.localRotation = Quaternion.Euler(currentCameraXRotation, 0, zRotation);

}

private Vector2 velocityGunFollow;
private float gunWeightX,gunWeightY;

public GameObject weapon;
private GunScript gun;


float deltaTime = 0.0f;

public bool showFps = true;

void OnGUI(){

	if(showFps){
		FPSCounter();
	}

}

void FPSCounter(){
	int w = Screen.width, h = Screen.height;

	GUIStyle style = new GUIStyle();

	Rect rect = new Rect(0, 0, w, h * 2 / 100);
	style.alignment = TextAnchor.UpperLeft;
	style.fontSize = h * 2 / 100;
	style.normal.textColor = Color.white;
	float msec = deltaTime * 1000.0f;
	float fps = 1.0f / deltaTime;
	string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
	GUI.Label(rect, text, style);
}

}
