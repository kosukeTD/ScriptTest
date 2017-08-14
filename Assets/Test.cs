﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2 {

	private int hp = 100; //体力
	private int power = 25; //攻撃力

	//攻撃用の関数
	public void Attack(){
		Debug.Log(this.power + "のダメージを与えた");
	}

	//防御用の関数
	public void Defence(int damage){
		Debug.Log(damage + "のダメージを受けた");
		//残りhpを減らす
		this.hp -= damage;
	}


}





public class Test : MonoBehaviour {


	void Start () {

		//Bossクラスの変数を宣言してインスタンスを代入
		Boss2 lastboss = new Boss2();

		//攻撃用の関数を呼び出す
		lastboss.Attack();
		//防御用の関数を呼び出す
		lastboss.Defence(3);

	}


	void Update () {
		
	}
}

