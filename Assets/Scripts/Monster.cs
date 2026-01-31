using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    public Vector3 velocity = Vector3.zero;
    public float detection_radius = 50.0f;
    public float stopping_radius = 3.0f;
    public float speed = 5.0f;
    public GameObject player;
    public NavMeshAgent agent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        float player_distance = (player.transform.position - transform.position).magnitude;
        if (player_distance < detection_radius && player_distance > stopping_radius)
        {
            // Points towards the player
            transform.forward = player.transform.position - transform.position;

            // Updates the velocity
            velocity = new Vector3(transform.forward.x, 0.0f, transform.forward.z) * speed;

            // Updates the position
            transform.position += velocity * Time.deltaTime;
        }


        









    }
}
