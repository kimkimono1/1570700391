using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

	void onTriggerExit(Collider other)
	{
		Object.DestroyObject (other.gameObject);
	}﻿
}
