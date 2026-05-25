using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject spawnPrenfab;  // プレイヤーのスポーン位置のプレハブ

    private float spawnIntval = 2f;
    private float spawnTimer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnIntval)
        {
            SpawnObject();
            spawnTimer = 0f;
        }
    }

    // オブジェクトをスポーンするメソッド

    private void SpawnObject()
    {
        Player player = GameObject.FindAnyObjectByType<Player>();
        float playerZ = player.transform.position.z;

        Vector3 randomPos = Vector3.zero;
        randomPos.x = Random.Range(-8, 8);
        randomPos.z = playerZ + 100;
        Instantiate(spawnPrenfab, randomPos, transform.rotation);
    }
}
