using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharSelect : MonoBehaviour {

    public GameObject spotLight;
    public GameObject spotLight2;
    private bool loading = false;
    public Text loadtext;
 
    // Use this for initialization
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (loading == true)
        {
            loadtext.color = new Color(loadtext.color.r,loadtext.color.g, loadtext.color.b, Mathf.PingPong(Time.time, 1));
        }
        Debug.Log(GlobalValues.PlayerElected);
    }

    void OnMouseOver()
    {
       
        spotLight.SetActive(true);
        spotLight2.SetActive(true);
      

    }

    void OnMouseDown()
    {
        if (loading == false)
        {
            loading = true;
            loadtext.text = "Loading...";
            StartCoroutine(LoadSceneMode());
            if (this.gameObject.name == "Player1")
            {
                GlobalValues.PlayerElected = 1;
            }else if (this.gameObject.name == "Player2")
            {
                GlobalValues.PlayerElected = 2;
            }
            else if (this.gameObject.name == "Player3")
            {
                GlobalValues.PlayerElected = 3;
            }
          
        }
    }

    void OnMouseExit()
    {
        spotLight.SetActive(false);
        spotLight2.SetActive(false);

    }

    IEnumerator LoadSceneMode()
    {
        yield return new WaitForSeconds(1);

        AsyncOperation async = SceneManager.LoadSceneAsync("Maze1Scene");

        while (!async.isDone)
        {
            yield return null;
        }
    }
}

