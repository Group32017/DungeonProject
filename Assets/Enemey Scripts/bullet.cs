using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour
{
    private float lifeTime = 3;
    private float time;
	// Use this for initialization
	void Start ()
	{
	    time = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
        
	    time += Time.deltaTime;
        if(time>lifeTime)
            Destroy(this.gameObject);
        
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
           
            GlobalValues.PlayerHealth -= 5;
            Destroy(this.gameObject);
        }
    }
}
