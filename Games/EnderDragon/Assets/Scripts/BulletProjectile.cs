﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour {

public float damage = 50f;

	public float GetDamage() {
		return damage;
	}

	public void Hit() {
		Destroy(gameObject);
	}
}
