using UnityEngine;
using System.Collections;

public class TurretFire : MonoBehaviour
{

    public Rigidbody Projectile;
    public float ProjectileSpeed;
    public float CoolDown;
    public float Timer;
    public bool CanFire = false;
   




    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        

	    if (CanFire == true)
	    {
	        Timer += Time.deltaTime;
	        if (Timer > CoolDown)
	        {
	            Fire();
	            Timer = 0;
	        }
	    }
	}

    void Fire()
    {
        Rigidbody clone = Instantiate(Projectile, transform.position , transform.rotation) as Rigidbody; 
        clone.velocity = transform.TransformDirection(Vector3.forward * ProjectileSpeed);
    }
}
