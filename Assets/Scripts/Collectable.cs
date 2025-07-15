using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{
    public int points;
    [SerializeField] private bool givesPoints;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (givesPoints)
            {
                ScoreManager.instance.AddPoints(points);
            }

            Destroy(gameObject);
        }
    }
}
