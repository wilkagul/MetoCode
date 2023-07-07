using UnityEngine;
using TMPro;

public class CodoMovement : MonoBehaviour
{
    public float speed = 5f;
    public string targetTag = "Target"; // Hedef nesnenin tag'i
    public GameObject correctPrefab; // FX prefab'i
    public GameObject wrongPrefab; // FX prefab'i
    public GameObject playerFx; // FX prefab'i

    private Transform target; // Hedef nesnenin referansı

    private void Start()
    {
        FindTarget();
    }

    private void FindTarget()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag(targetTag);
        if (targetObject != null)
        {
            target = targetObject.transform;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(targetTag)) // Çarpışan nesne Planet tag'ine sahipse ve daha önce çarpmadıysa
        {
            AudioPlayer.Instance.CodePlanetClip();

            Transform transformObje = this.gameObject.transform.GetChild(0);
            TextMeshPro textObje = transformObje.GetComponent<TextMeshPro>();
            string answer = textObje.text;
            string res = LevelManager.Instance.GetResult();

            if (answer == res)
            {
                Instantiate(correctPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                LevelManager.Instance.SetLevelIndex();
                ConsolVisualizer.Instance.SetQuestion();
            }
            else
            {
                Instantiate(wrongPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            }

            gameObject.SetActive(false); // Enemy'yi devre dışı bırak

        }

        if (collision.CompareTag("Player")) // Çarpışan nesne Planet tag'ine sahipse ve daha önce çarpmadıysa
        {
            AudioPlayer.Instance.PlayerShootingClip();
            Instantiate(playerFx, transform.position, Quaternion.identity);
            gameObject.SetActive(false); // Enemy'yi devre dışı bırak
        }
    }

    private void Update()
    {
        if (target != null)
        {
            Vector3 direction = target.position - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
    }
}
