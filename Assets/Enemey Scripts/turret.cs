using UnityEngine;
using System.Collections;

public class turret : MonoBehaviour
{

    public GameObject player ;
    public Vector3 RotateSpeedVector3;
    public TurretFire turretFire;
    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }
	
	// Update is called once per frame
	void Update () {
        
        var direction = player.transform.position - transform.position;
        var angle = Vector3.Angle(direction, transform.forward);
	    if (Vector3.Distance(player.transform.position, transform.position) < 5 && angle < 90)
	    {
	        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.1f);
	        turretFire.CanFire = true;
	    }
	    else
	       turretFire.CanFire = false;
          transform.Rotate(RotateSpeedVector3 * Time.deltaTime);

    }
}
