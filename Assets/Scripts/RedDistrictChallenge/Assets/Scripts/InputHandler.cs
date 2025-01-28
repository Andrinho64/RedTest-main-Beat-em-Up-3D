using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private PlayerAttack playerAttack;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerAttack = GetComponent<PlayerAttack>();
    }

    void Update()
    {
        HandleMovementInput();
        HandleAttackInput();
    }

    void HandleMovementInput()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0, vertical);
        playerMovement?.Move(moveDirection);
    }

    void HandleAttackInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAttack?.PerformAttack();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            playerAttack?.UseSpecialAttack();
        }
    }
}
