using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    // Source -> https://kenney.nl/assets/sci-fi-sounds
    public static AudioPlayer Instance { get; private set; }

    [Header("Player")]
    [SerializeField] AudioClip playerShootingClip;
    [SerializeField][Range(0f, 1f)] float playerShootingVolume = 1.0f;


    [Header("EnemyPlanet")]
    [SerializeField] AudioClip enemyPlanetClip;
    [SerializeField][Range(0f, 1f)] float enemyPlanetVolume = 1.0f;


    [Header("CodePlanet")]
    [SerializeField] AudioClip codePlanetClip;
    [SerializeField][Range(0f, 1f)] float codePlanetVolume = 1.0f;


    private void Awake()
    {
        Instance = this;
    }

    public void PlayerShootingClip()
    {
        PlayClip(playerShootingClip, playerShootingVolume);
    }

    public void EnemyPlanetClip()
    {
        PlayClip(enemyPlanetClip, enemyPlanetVolume);
    }

    public void CodePlanetClip()
    {
        PlayClip(codePlanetClip, codePlanetVolume);
    }


    private void PlayClip(AudioClip clip, float volume)
    {
        if (clip != null)
        {
            Vector3 camPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, camPos, volume);
        }
    }
}