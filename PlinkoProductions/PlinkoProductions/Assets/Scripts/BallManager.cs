using UnityEngine;
using System.Collections;

public class BallManager : MonoBehaviour
{
    public UpgradeManager upgradeManager;

    [SerializeField] private AudioClip spawnSoundClip;
    public GameObject ballPrefab;
    public float timer;

    void Start()
    {
        float screenWidth = Camera.main.orthographicSize * Camera.main.aspect * 2;
        float range = screenWidth / 4;
        float randomX = Random.Range(-range, range);
        float topY = Camera.main.orthographicSize;
        float spawnY = topY;

        Instantiate(ballPrefab, new Vector3(randomX, spawnY, 0), Quaternion.identity);
        Time.timeScale = (1 + upgradeManager.gameSpeedMultiplier);
        SoundManager.instance.SpawnSoundEffect(spawnSoundClip, transform, 1f);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= upgradeManager.ballSpawnSpeed)
        {
            SpawnBalls();
            timer = 0;
        }
    }

    // Function to handle spawning of balls
    void SpawnBalls()
    {
        float screenWidth = Camera.main.orthographicSize * Camera.main.aspect * 2;
        float range = screenWidth / 4;
        float topY = Camera.main.orthographicSize;
        float spawnY = topY;

        float randomX = Random.Range(-range, range);
        SpawnBall(randomX, spawnY);

        // Bonus ball chance
        if (Random.value < upgradeManager.bonusBallChance)
        {
            randomX = Random.Range(-range, range); // Ensure different X
            SpawnBall(randomX, spawnY);
        }
    }

    // Helper function to spawn a ball at a given X and Y position
    void SpawnBall(float x, float y)
    {
        Instantiate(ballPrefab, new Vector3(x, y, 0), Quaternion.identity);
        StartCoroutine(PlaySpawnSoundDelayed());
    }

    private IEnumerator PlaySpawnSoundDelayed()
    {
        yield return new WaitForSeconds(0.2f);
        SoundManager.instance.SpawnSoundEffect(spawnSoundClip, transform, 1f);
    }
}