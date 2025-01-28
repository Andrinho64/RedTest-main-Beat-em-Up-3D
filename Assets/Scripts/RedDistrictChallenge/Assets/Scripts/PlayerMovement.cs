using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        controller.Move(direction * moveSpeed * Time.deltaTime);
    }

    // 🔹 Criar um método público para ser chamado no InputHandler.cs
    public void Move(Vector3 direction)
    {
        controller.Move(direction * moveSpeed * Time.deltaTime);
    }
}
