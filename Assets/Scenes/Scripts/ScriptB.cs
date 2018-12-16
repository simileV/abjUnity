using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptB : MonoBehaviour
{
    private int enemyDistance = 0;
    private int enemyCount = 10;

    private string[] enemies = new string[5];
    private int weaponId = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            WeaponSearch();
            //EnemySearch();
            //EnemyDestruction();
            //EnemyScan();
            //EnemyRoster();

        }
    }

    void WeaponSearch()
    {
        //weaponId = Random.range(1, 5);
        weaponId = Random.Range(0, 8);

        switch (weaponId)
        {
            case 1:
                print("you found a sword");
                break;
            case 2:
                print("you found a gem");
                break;
            case 3:
                print("you found a bow");
                break;
            case 4:
                print("you found a dagger");
                break;
            default:
                print("you didnt find anything");
                break;
        }
    }

    void EnemySearch()
    {
        for (int i = 0; i < 5; i++)
        {
            enemyDistance = Random.Range(1, 10);

            if (enemyDistance >= 8)
            {
                print("an enemy is far away");
            }

            if (enemyDistance >= 4 && enemyDistance <= 7)
            {
                print("an enemy is at med range");
            }

            if (enemyDistance < 4)
            {
                print("an enemy is very close");
            }
        }
    }

    void EnemyDestruction()
    {
        while (enemyCount > 0)
        {
            print("there is an enemy, lets destroy it");
            enemyCount--;
        }
    }

    void EnemyScan()
    {
        bool isAlive = false;

        do
        {
            print("scanning for enemies");
        }

        while (isAlive == true);
    }

    void EnemyRoster()
    {
        enemies[0] = "Orc";
        enemies[1] = "Dragon";
        enemies[2] = "Orc";
        enemies[3] = "Dragon";
        enemies[4] = "Dragon";

        foreach (string enemy in enemies)
        {
            print(enemy);
        }
    }
}