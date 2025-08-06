using UnityEngine;
using Ilumisoft.HealthSystem;
using System.Collections;

public class Trigger : MonoBehaviour
{
    public Health health;
    private bool canDamage = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        health.ApplyDamage(5f);
        Debug.Log("Trigger entered, applying damage.");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (canDamage)
        {
            Health health = other.GetComponent<Health>();

            if (health != null)
            {
                StartCoroutine(ApplyDamageOverTime(health));
            }
        }
    }
    private IEnumerator ApplyDamageOverTime(Health health)
    {
        canDamage = false;

        health.ApplyDamage(5f);
        Debug.Log("Trigger entered, applying damage.");

        yield return new WaitForSeconds(0.25f);

        canDamage = true;
    }
}
