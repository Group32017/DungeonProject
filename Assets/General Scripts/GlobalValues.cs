using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GlobalValues : MonoBehaviour {

	public static int PlayerElected = 0 ;
    public static int PlayerHealth;
    public static bool FirstSpawn = true;
    public static int Ammo = 30;

    public static void Die()
    {
        new WaitForSeconds(3);
        SceneManager.LoadScene("Maze1Scene");
        PlayerHealth = 100;
    }
}
