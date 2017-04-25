using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class Bullet : MonoBehaviour
{

    private float direction = 0.5f;

    // Use this for initialization
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        if(player.GetComponent<Rigidbody2D>().velocity.x <= 0)
        {
            direction *= -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(direction, 0, 0);
        if(gameObject.transform.position.x > 10 || gameObject.transform.position.x < -10)
        {
            Destroy(this.gameObject);
        }
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        GameObject.Find("An Unassuming Box").GetComponent<EnemyManager>().enemyHit(coll.gameObject);
    }
}
