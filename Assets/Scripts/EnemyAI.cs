using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class EnemyAI : MonoBehaviour
{

    private int direction = 1;

    // Use this for initialization
    void Start()
    {
        if(Random.Range(0, 2) == 0)
        {
            direction *= -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool temp = false;
        if(Random.Range(0, 5) < 1)
        {
            temp = true;
        }

        gameObject.GetComponent<PlatformerCharacter2D>().Move(direction, false, temp);
        if(gameObject.transform.position.x > 9.0f)
        {
            direction = -1;
        }
        else if(gameObject.transform.position.x < -9.0f)
        {
            direction = 1;
        }
    }
}
