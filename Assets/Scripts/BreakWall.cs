using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BreakWall : MonoBehaviour
{
    [SerializeField] private TMP_Text hpText;
    public GameObject Explosion;

    [Header("Stats")]
    public int health;

    private void Start()
    {
        hpText.text =health.ToString();
    }
    public void TakeDmg(int dmg)
    {
        Debug.Log("Wall hit");
        Instantiate(Explosion, transform.position, Quaternion.identity);
        health -= dmg;
        UpdateHealthText();
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void UpdateHealthText()
    {
        hpText.text = health.ToString();
    }
}
