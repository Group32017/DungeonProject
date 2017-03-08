using UnityEngine;


public class enem : MonoBehaviour
{
    public Transform player;
    public PlayerHealth _playerHealth;
    private int timeNo = 0; 
    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        var direction = player.position - transform.position;
        var angle = Vector3.Angle(direction, transform.forward);
        if (Vector3.Distance(player.position, transform.position) < 15 && angle < 90)
        {
            direction.y = 0;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            if (direction.magnitude < 8 && direction.magnitude > 2)
                transform.Translate(0, 0, 0.05f);
            else if (direction.magnitude < 2)
            {
                if (timeNo == 40)
                {
                   // _playerHealth.ApplyDamage(5);
                    timeNo = 0;
                }
                else
                {
                    timeNo++;
                }
            }
        }
    }
}