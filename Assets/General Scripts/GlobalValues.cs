using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GlobalValues : MonoBehaviour {

    public static int PlayerElected = 0;
    public static int PlayerHealth;

    public static bool FirstSpawn = true;

    public static int Ammo;
    public static int TotalAmmo;

    public static int PistolClipSize = 15;
    public static int ShootGunClipSize = 8;

    public static int TurretMaxHealth = 10;
    public static int BossHealth = 40;

    public static void Die()
    {
        new WaitForSeconds(3);
        SceneManager.LoadScene("Maze1Scene");
        PlayerHealth = 100;
    }

    public static void Realod()
    {
        if (PlayerElected == 2)
        {
            if (Ammo == 0 && TotalAmmo >= 15)
            {
                Ammo = PistolClipSize;
                TotalAmmo -= PistolClipSize;
            }
            else if (Ammo == 0 && TotalAmmo >= 0)
            {
                Ammo = TotalAmmo;
                TotalAmmo = 0;
            }


        }
    }
}
