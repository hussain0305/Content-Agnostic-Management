using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour
{
    public GameObject objective;
    public GameObject[] enemies;
    private char[] enemyNums;

    // Use this for initialization
    void Start()
    {
        objective.GetComponent<TextMesh>().text = FrameworkCore.currentContent.getTerm();
        enemyNums = new char[enemies.Length];
        for (int i = 0; i < enemies.Length; i++)
        {
            generateEnemy(i);
        }
    }

    private void generateEnemy(int index)
    {
        enemyNums[index] = FrameworkCore.currentContent.getItem();
        makeEnemy(enemies[index], enemyNums[index]);
    }

    private void makeEnemy(GameObject enemy, char item)
    {
        GameObject temp = (GameObject)Instantiate(enemy, new Vector3(Random.Range(-8, 9), 5.0f, 0.0f), Quaternion.identity);
        temp.GetComponentInChildren<TextMesh>().text = "" + item;
    }

    public void enemyHit(GameObject enemy)
    {
        int index = -1;
        for (int i = 0; i < enemyNums.Length; i++)
        {
            TextMesh temp = enemy.GetComponent<TextMesh>();
            if (temp != null)
            {
                Debug.Log(enemyNums[i]);
                Debug.Log(temp.text.ToCharArray()[0]);
                if (enemyNums[i] == temp.text.ToCharArray()[0])
                {
                    index = i;
                }
            }
        }

        if (index != -1)
        {
            //RoboShooterMechanics temp = (RoboShooterMechanics)GameInfo.currentMechanics;
            //temp.sendHook(enemyNums[index], enemyNums);
            //if (FrameworkCore.currentContent.wasLastActionValid())
            //{
            //    Destroy(enemies[index]);
            //    generateEnemy(index);
            //}
        }
    }
}
