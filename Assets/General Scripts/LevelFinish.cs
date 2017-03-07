using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    public string nextLevel;
	// Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            SceneManager.LoadScene(nextLevel);
        }
    }
}
