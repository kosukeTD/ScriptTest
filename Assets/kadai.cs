using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int[] array = new int[5];

		array [0] = 15;
		array [1] = 30;
		array [2] = 45;
		array [3] = 60;
		array [4] = 75;

		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}

			for(int r=4;r >= 0; r--){
				Debug.Log (array [r]);
		
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
