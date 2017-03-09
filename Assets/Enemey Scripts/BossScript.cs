using UnityEngine;


public class BossScript : MonoBehaviour
{
    public Animator animat;
    public GameObject player;
    private int timeNo = 0; 
    // Use this for initialization
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animat = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        var direction = player.transform.position - transform.position;
        var angle = Vector3.Angle(direction, transform.forward);
        if (Vector3.Distance(player.transform.position, transform.position) < 10 && angle < 90)
        {
            direction.y = 0;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.1f);
            State(3);
            if (direction.magnitude < 6 && direction.magnitude > 2)
            {
                transform.Translate(0, 0, 0.05f);
                State(1);
            }
            else if (direction.magnitude < 2)
            {
                if (timeNo == 40)
                {
                    State(4);
                    GlobalValues.PlayerHealth -= 5;
                    timeNo = 0;
                }
                else
                {
                    timeNo++;
                }
            }
        }else if(Vector3.Distance(player.transform.position, transform.position) > 90)
        State(0);
    }

    private void State(int state)
    {
        animat.SetInteger("State", state);
    }
}