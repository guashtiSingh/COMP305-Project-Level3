﻿using UnityEngine;
using System.Collections;

public class PlatformFall : MonoBehaviour {

		public float fallDelay = 1f;

		private Rigidbody2D rb2d;

		void Awake() {
			rb2d = GetComponent<Rigidbody2D> ();
		}

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}

		void OnCollisionEnter2D (Collision2D other) {
			if (other.gameObject.CompareTag ("Player")) {
				Invoke ("Fall", fallDelay);
			}
		}

		void Fall() {
			rb2d.isKinematic = false;
		}
}
