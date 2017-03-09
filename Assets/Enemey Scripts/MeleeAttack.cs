using UnityEngine;
using System.Collections;

public class MeleeAttack : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("hit");
        IDmg dmg = col.gameObject.GetComponent<IDmg>();
        if (dmg != null)
        {
            dmg.TakeDamage(10);
        }
    }
}