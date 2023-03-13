using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float playerSpeed = 10f;
    private float playerTurnSpeed = 100f;

    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        Move(playerSpeed * forwardInput, playerTurnSpeed * horizontalInput);
    }

    public void Move(float speed, float turnSpeed)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed);
    }
}
