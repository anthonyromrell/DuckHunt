﻿using UnityEngine;
using System.Collections;
using System;

public class WeaponSPGun : MonoBehaviour {

	public static Action<Transform> SendSpawnPoint;

	void Start () {
		if (SendSpawnPoint != null)
			SendSpawnPoint (transform);
	}
}
