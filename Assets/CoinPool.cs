using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public int coinPoolSize = 4;
    private GameObject[] coin;
    public float spawnRate = 2f;
    public float coinMin = -1f;
    public float coinMax = 3.5f;

    public GameObject coinPrefab;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentCoin = 0;
    // Start is called before the first frame update
    void Start()
    {
        coin = new GameObject[coinPoolSize];
        for (int i = 0; i < coinPoolSize; i++)
        {
            coin[i] = (GameObject)Instantiate(coinPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;

            //Set a random y position for the column
            float spawnYPosition = Random.Range(coinMin, coinMax);

            //...then set the current column to that position.
            coin[currentCoin].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            //Increase the value of currentColumn. If the new size is too big, set it back to zero
            currentCoin++;

            if (currentCoin >= coinPoolSize)
            {
                currentCoin = 0;
            }
        }
    }
}
