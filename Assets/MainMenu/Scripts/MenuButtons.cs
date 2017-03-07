using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject aboutMenu;

    public void Play()
    {
        SceneManager.LoadScene("CharacterSelectScene");
    }

    public void About()
    {
        aboutMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Back()
    {
        aboutMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
