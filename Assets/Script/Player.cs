using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private float speed = 5.0f;
    private Vector2 moveInput;

    // 移動範囲
    public float minX = -8f;
    public float maxX = 8f;
    public float minY = -4f;
    public float maxY = 4f;

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 move = new Vector3(
            moveInput.x,
            moveInput.y,
            0);

        // 移動
        transform.position += move * speed * Time.deltaTime;

        // 制限
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = pos;
    }
}