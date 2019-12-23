using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalCulator : MonoBehaviour {

	public InputField Input1;
	public InputField Input2;
	public Text MainResult;

	// Use this for initialization
	void Start () {
		MainResult.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void add() {
		int num1 = int.Parse (Input1.text);
		int num2 = int.Parse (Input2.text);
		MainResult.text = (num1 + num2).ToString(); 
	}

	public void Subtract() {
		int num1 = int.Parse (Input1.text);
		int num2 = int.Parse (Input2.text);
		MainResult.text = (num1 - num2).ToString(); 
	}

	public void MulTiPlay() {
		int num1 = int.Parse (Input1.text);
		int num2 = int.Parse (Input2.text);
		MainResult.text = (num1 * num2).ToString(); 
	}

	public void Devide() {
		int num1 = int.Parse (Input1.text);
		int num2 = int.Parse (Input2.text);
		MainResult.text = (num1 / num2).ToString(); 
	}
}
