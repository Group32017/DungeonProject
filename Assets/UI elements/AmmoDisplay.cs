using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{
    public Text AmmoValue;
	// Use this for initialization
	void Start ()
	{
	    AmmoValue = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    AmmoValue.text = GlobalValues.Ammo.ToString();
	}
}
