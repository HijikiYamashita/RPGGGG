using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public int enemyHP;
    public int enemyATK;
    public int enemyDEF;

    //public GameObject player;
    //PlayerScript playerSc;

    int damage;
    int basicDamage;
    int randomDamage;

    int random;

    public Text enemyHPText;

    void Start()
    {
        //playerSc = player.GetComponent<PlayerScript>();
    }

    void Update()
    {
        enemyHPText.text = enemyHP.ToString();
        if (enemyHP <= 0)
        {
            SceneManager.LoadScene("Masaru");
        }
    }

    public void enemyAttack()
    {
        basicDamage = enemyATK / 2 - PlayerScript.playerDEF / 4;
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
        PlayerScript.playerHP = PlayerScript.playerHP - damage;
    }
}
