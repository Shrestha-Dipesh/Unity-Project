using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] zombieReference;

    [SerializeField]
    private Transform leftPos, rightPos;

    private GameObject spawnedZombie;
    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnZombies());
    }

    IEnumerator SpawnZombies()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            randomIndex = Random.Range(0, zombieReference.Length);
            randomSide = Random.Range(0, 2);

            spawnedZombie = Instantiate(zombieReference[randomIndex]);

            if (randomSide == 0)
            {
                spawnedZombie.transform.position = leftPos.position;
                spawnedZombie.GetComponent<Enemy>().speed = Random.Range(4, 10);
            }
            else
            {
                spawnedZombie.transform.position = rightPos.position;
                spawnedZombie.GetComponent<Enemy>().speed = -Random.Range(4, 10);
                spawnedZombie.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
    }
}
