using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public static int playerHP = 570;
    public static int playerATK = 404;
    public static int playerDEF = 357;

    public GameObject enemy;
    EnemyScript enemySc;

    int damage;
    int basicDamage;
    int randomDamage;

    int random;

    public Text damageText;
    public Text playerHPText;

    void Start()
    {
        enemySc = enemy.GetComponent<EnemyScript>();
        /*for (int a = 0; a <= 4; a++)
        {
            playerAttack();
        }*/
    }

    void Update()
    {
        damageText.text = "-" + damage.ToString();
        playerHPText.text = playerHP.ToString();
        if (playerHP <= 0)
        {
            SceneManager.LoadScene("Makeru");
        }
    }

    public void playerAttack()
    {
        basicDamage = playerATK / 2 - enemySc.enemyDEF / 4;
        randomDamage = basicDamage / 16;
        random = Random.Range(0, 101);
        if (random <= 50)
        {
            damage = basicDamage + Random.Range(0, randomDamage + 1);
        }
        if (random >= 51)
        {
            damage = basicDamage - Random.Range(0, randomDamage + 1);
        }
        enemySc.enemyHP = enemySc.enemyHP - damage;
        enemySc.enemyAttack();
    } 
}
