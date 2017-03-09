using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour
{
    public float range = 40f;
    public int damage = 5;

    private Camera mainCamera;

    // Use this for initialization
    void Start()
    {
        mainCamera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 rayOriginVector3 = mainCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));

        if (Input.GetButtonDown("Fire1"))
        {
            if (GlobalValues.Ammo > 0)
            {

                GlobalValues.Ammo -= 1;
                if (Physics.Raycast(rayOriginVector3, mainCamera.transform.forward, out hit, range))
                {
                    IDmg dmg = hit.collider.gameObject.GetComponent<IDmg>();
                    if (dmg != null)
                    {
                        dmg.TakeDamage(damage);
                    }
                }
            }
            else
            {
                GlobalValues.Realod();
            }
        }
    }
}