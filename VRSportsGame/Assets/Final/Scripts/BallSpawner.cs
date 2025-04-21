using UnityEngine;
using UnityEngine.InputSystem;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject PaddlePrefab;
    public Transform spawnLocation;
    public Vector3 spawnOffset = new Vector3(0, -0.5f, 1f);

    public InputActionReference spawnBallAction;
    public InputActionReference spawnPaddleAction;

    private void OnEnable()
    {
        spawnBallAction.action.Enable();
        spawnBallAction.action.performed += OnSpawnBall;

        spawnPaddleAction.action.Enable();
        spawnPaddleAction.action.performed += OnSpawnPaddle;
    }

    private void OnDisable()
    {
        spawnBallAction.action.performed -= OnSpawnBall;
        spawnBallAction.action.Disable();

        spawnPaddleAction.action.performed -= OnSpawnPaddle;
        spawnPaddleAction.action.Disable();
    }

    private void OnSpawnBall(InputAction.CallbackContext context)
    {
        Vector3 spawnPosition = spawnLocation.position;
        Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }

    private void OnSpawnPaddle(InputAction.CallbackContext context)
    {
        Vector3 spawnPosition = spawnLocation.position;
        Instantiate(PaddlePrefab, spawnPosition, Quaternion.identity);
    }
}
