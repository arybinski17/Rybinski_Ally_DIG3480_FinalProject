using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlRyCharacterAnim : MonoBehaviour {

private Animator anim;

void Start() {
	anim = GetComponent<Animator>();
}

void Update() {
	if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)){
		anim.SetBool("isWalking", true);
	} else {
		anim.SetBool("isWalking", false);
	}
}
}
