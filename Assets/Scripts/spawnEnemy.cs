using System.Collections;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    private float spawnPause = 2.0f;
    
    void Start()
    {
        StartCoroutine(CloneEnemyPrefab());
    }

    IEnumerator CloneEnemyPrefab()
    {
        while (true)
        {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-6, 6), 0, 180), Quaternion.Euler(0, 180, 0));
            yield return new WaitForSeconds(spawnPause);
        }
    }
}
