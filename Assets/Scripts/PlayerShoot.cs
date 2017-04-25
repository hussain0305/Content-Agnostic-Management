using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;

    private int shotDelay = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(shotDelay > 0)
        {
            shotDelay--;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                shotDelay = 30;
                Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
            }
            else if(Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
