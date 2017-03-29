using UnityEngine;
using UnityEngine.UI;

public class EnemyBeh : MonoBehaviour {

    public float startSpeed = 10f;

    [HideInInspector]
    public float speed;

    public float startHealth = 100f;
    private float health;
    public int value = 50;

    private bool isDead = false;

    void Start()
    {
        speed = startSpeed;
        health = startHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        //healthBar.fillAmount = health / startHealth;

        if (health <= 0f && isDead == false)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        //PlayerStats.money += value;
        Destroy(gameObject);
        //WaveSpawner.EnemiesAlive--;
    }

    public void Slow(float percent)
    {
        speed = startSpeed * (1f - percent);
    }
}
