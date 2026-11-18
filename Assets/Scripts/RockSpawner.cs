using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField] private GameObject rock;

    float timer = 0f;
    [SerializeField] private float spawnTime = 5f;

    private Vector3 spawnPosition = new Vector3(0f, 0f, 50);

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0f)
        {
            timer = spawnTime;

            float xPosiotion = Random.Range(-10f, 10f);
            spawnPosition.x = xPosiotion;
            Instantiate(rock, spawnPosition, transform.rotation);

        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
