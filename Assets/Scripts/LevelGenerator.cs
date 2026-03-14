using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject chunkPrefab;
    [SerializeField] private int startingChunksAmount = 12;
    [SerializeField] private Transform chunkParent;
    [SerializeField] private float chunkLength = 10f;
    [SerializeField] private float moveSpeed = 8f;

    private GameObject[] chunks = new GameObject[12];


    private void Start()
    {
        SpawnChunks();
    }

    private void Update()
    {
        MoveChuncks();
    }

    private void SpawnChunks()
    {
        for (int i = 0; i < startingChunksAmount; i++)
        {
            Vector3 chunkSpawnPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + (chunkLength * i));

            chunks[i] = Instantiate(chunkPrefab, chunkSpawnPos, Quaternion.identity, chunkParent);
        }
    }

    private void MoveChuncks()
    {
        for (int i = 0;i < chunks.Length; i++)
        {
            chunks[i].transform.Translate(-transform.forward * (moveSpeed * Time.deltaTime));
        }
    }
}
