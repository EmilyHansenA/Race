using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private string playerTag = "Player";
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == playerTag)
        {
            SceneManager.LoadScene(0);
        }
    }
}
