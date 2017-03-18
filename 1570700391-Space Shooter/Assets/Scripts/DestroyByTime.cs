using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	void onTriggerExit(Collider other)
	{
		Object.DestroyObject (other.gameObject);
	}﻿
}
