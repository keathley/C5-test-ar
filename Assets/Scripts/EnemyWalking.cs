using UnityEngine;
using System.Collections;

public class EnemyWalking : MonoBehaviour {

	public float speed = 6f;
	public float rotationSpeed = 30.0f;

	private Animator anim;

	void Awake () {
		anim = GetComponent<Animator> ();
		anim.SetBool ("IsWalking", true);
	}

	void Update () {
		transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
		transform.Translate (Vector3.forward * Time.deltaTime);
	}
}
