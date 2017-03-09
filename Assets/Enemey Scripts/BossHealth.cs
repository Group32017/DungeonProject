using UnityEngine;
using System.Collections;

public class BossHealth : MonoBehaviour, IDmg
{

    private int currentHealth;
    // Use this for initialization
    void Start()
    {
        currentHealth = GlobalValues.BossHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int dmg)
    {
        currentHealth -= dmg;
        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        Destroy(this.gameObject);
    }
}
