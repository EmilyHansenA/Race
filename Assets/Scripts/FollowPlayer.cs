using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private Vector3 offset = new Vector3(0, 6, -7);
    
    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
