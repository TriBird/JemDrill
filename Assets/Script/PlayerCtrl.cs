using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerCtrl: MonoBehaviour{

	private bool isDigging = false;
	private ItemLot itemlot_if;

	void Start() {
		itemlot_if = new ItemLot();
	}

	private void Update()	{
		if(Input.GetKey(KeyCode.Space)){
			DigOnce();
		}
	}

	public void DigOnce(){
		if(isDigging) return;
		isDigging = true;

		transform.Find("Drill").DOShakePosition(0.5f, 20, 30).OnComplete(() => isDigging = false);
	}
}