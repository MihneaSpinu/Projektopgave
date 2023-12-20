using System.Collections;
using System.Threading;
using UnityEngine;

public class Dummy_Test_Atk : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private float damageDelay = 1f; // delay in seconds
    [SerializeField] private int damage = 10;
    private bool canTakeDamage = true;
    
    // Start is called before the first frame update
    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.

    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject && canTakeDamage)
        {
            StartCoroutine(DamageDelay());
            TakeDamage(damage);
            Debug.Log("I took damage");
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    IEnumerator DamageDelay()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(damageDelay);
        canTakeDamage = true;
    }

    public void Die()
    {
        Debug.Log("I died");
        Destroy(gameObject);
    }

    public int GetHealth()
    {
        return health;
    }

    public void Heal(int healAmount)
    {
        health += healAmount;
    }
}
