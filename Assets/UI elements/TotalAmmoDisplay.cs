using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TotalAmmoDisplay : MonoBehaviour
{
    public Text AmmoValue;
    // Use this for initialization
    void Start()
    {
        AmmoValue = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        AmmoValue.text = GlobalValues.TotalAmmo.ToString();
    }
}
