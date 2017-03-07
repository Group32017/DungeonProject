using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Text HealthValueText;

    void Start()
    {
        HealthValueText = GetComponent<Text>();
    }
	// Update is called once per frame
	void Update ()
	{
	    HealthValueText.text = GlobalValues.PlayerHealth.ToString();
	}

    
}
