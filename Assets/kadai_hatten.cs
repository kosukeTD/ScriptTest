using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss {

	private int mp = 53;
	int mpNokori;

	public void Magic(int magicPower){
		mpNokori = this.mp - magicPower;
		if (mpNokori >= 0) {
			Debug.Log ("魔法攻撃をした。残りMPは" + mpNokori + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
				this.mp -= magicPower;
		}

	}



public class kadai_hatten : MonoBehaviour {


	void Start () {
		Boss kadaiboss = new Boss ();

		for (int i = 1; i <= 11; i++) {
			kadaiboss.Magic (5);
		}

		/*
		kadaiboss.Magic (5);

		kadaiboss.Magic (5);
		kadaiboss.Magic (5);
		kadaiboss.Magic (5);
		kadaiboss.Magic (5);
		kadaiboss.Magic (5);
		kadaiboss.Magic (5);
		kadaiboss.Magic (5);
		kadaiboss.Magic (5);
		kadaiboss.Magic (5);
		kadaiboss.Magic (5);
		*/



	}
		
	
	void Update () {
		
	}
}
