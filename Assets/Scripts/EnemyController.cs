using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float enemySpeed = 20f;
    private void Update()
    {
        EnemyMove();
    }

    public void EnemyMove()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * enemySpeed);
    }
}
