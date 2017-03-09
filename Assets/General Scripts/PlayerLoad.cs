using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerLoad : MonoBehaviour
{

    public Transform player1;
    public Transform player2;
    public Transform player3;
    public GameObject spawnPoint;
    private bool spawned = false;
    public Text PlayerHealthText;
    public GameObject Player2UI;

    // Use this for initialization
    void Start () {
        if (!spawned)
        {

            switch (GlobalValues.PlayerElected)
            {
                case 1:
                    Instantiate(player1, spawnPoint.transform.position, spawnPoint.transform.rotation);
                    spawned = true;
                    break;

                case 2:
                    Instantiate(player2, spawnPoint.transform.position, spawnPoint.transform.rotation);
                    Player2UI.SetActive(true);
                    GlobalValues.Ammo = GlobalValues.PistolClipSize;
                    GlobalValues.TotalAmmo = GlobalValues.PistolClipSize * 2;
                    spawned = true;
                    break;

                case 3:
                    Instantiate(player3, spawnPoint.transform.position, spawnPoint.transform.rotation);
                    GlobalValues.Ammo = GlobalValues.ShootGunClipSize;
                    GlobalValues.TotalAmmo = GlobalValues.ShootGunClipSize * 2;
                    Player2UI.SetActive(true);
                    spawned = true;
                    break;
            }

            if (GlobalValues.FirstSpawn)
            {
                PlayerHealthText.text = "100";
                GlobalValues.FirstSpawn = false;
                GlobalValues.PlayerHealth = 100;
            }else
            PlayerHealthText.text = GlobalValues.PlayerHealth.ToString();
        }
        

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
