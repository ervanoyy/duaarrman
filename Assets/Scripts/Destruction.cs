using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {

	public GameObject destroyedVersion;

	public void DestructionBomb() {
		Instantiate(destroyedVersion, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
