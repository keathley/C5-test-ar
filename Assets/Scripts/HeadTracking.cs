using UnityEngine;
using System.Collections;

public class HeadTracking : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.LookAt (Camera.mainCamera.gameObject.transform);
		transform.Rotate (new Vector3(0f, -90f, -90f));
	}
}
