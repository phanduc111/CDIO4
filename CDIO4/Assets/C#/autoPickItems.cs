using UnityEngine;

public class autoPickItems : MonoBehaviour
{
    Transform player;
    [SerializeField] float speed = 2.5f;
    [SerializeField] float Distance_pickup = 1.5f;
    [SerializeField] float timeOf_exist = 5f;

    private void Awake()
    {
        player = gameManager.instance.player.transform;
    }

    // Update is called once per frame
    private void Update()
    {
        timeOf_exist -= Time.deltaTime;
        if (timeOf_exist < 0) { Destroy(gameObject); }

        float distance = Vector3.Distance(transform.position, player.position);
        if(distance > Distance_pickup)
        {
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, 
            player.position, speed * Time.deltaTime);

        if (distance < 0.1f) {
            Destroy(gameObject);
        }

    }
}
