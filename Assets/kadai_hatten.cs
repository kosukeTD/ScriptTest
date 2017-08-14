using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss {

	private int mp = 53;
	int mpNokori;

	public void Magic(int magicPower){
		mpNokori = this.mp - magicPower;
		Debug.Log ("魔法攻撃をした。残りMPは" + mpNokori + "。");
		this.mp -= magicPower;


		if (this.mp <= 0) {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}

	}
}


public class kadai_hatten : MonoBehaviour {


	void Start () {
		Boss kadaiboss = new Boss ();

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



	}
		
	
	void Update () {
		
	}
}
