using UnityEngine;


public class EnemyMovement : MonoBehaviour
{
    public GameObject wrongPrefab; // FX prefab'i
    public GameObject correntPrefab; // FX prefab'i

    public float speed = 5f;

    private void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Planet")) // Çarpışan nesne Planet tag'ine sahipse ve daha önce çarpmadıysa
        {
            // FX prefab'ini yarat
            Instantiate(wrongPrefab, transform.position, Quaternion.identity);
            AudioPlayer.Instance.EnemyPlanetClip();
            gameObject.SetActive(false); // Enemy'yi devre dışı bırak
        }


        if (collision.CompareTag("Player")) // Çarpışan nesne Planet tag'ine sahipse ve daha önce çarpmadıysa
        {
            // FX prefab'ini yarat
            Instantiate(correntPrefab, transform.position, Quaternion.identity);
            AudioPlayer.Instance.PlayerShootingClip();
            gameObject.SetActive(false); // Enemy'yi devre dışı bırak
        }

    }
}
