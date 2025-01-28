using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float lastAttackTime;
    private int comboCount = 0;

    public float specialCooldown = 5f;
    private bool canUseSpecial = true;
    private float specialCooldownTimer = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canUseSpecial)
        {
            UseSpecialAttack();
        }

        if (!canUseSpecial)
        {
            specialCooldownTimer -= Time.deltaTime;
            if (specialCooldownTimer <= 0)
            {
                canUseSpecial = true;
            }
        }
    }

    // 🔹 Nome atualizado para corresponder ao InputHandler
    public void PerformAttack()
    {
        lastAttackTime = Time.time;
        comboCount++;

        if (comboCount == 1)
        {
            Debug.Log("Golpe 1");
        }
        else if (comboCount == 2)
        {
            Debug.Log("Golpe 2");
        }
        else if (comboCount == 3)
        {
            Debug.Log("Golpe 3");
            comboCount = 0; // Reseta o combo
        }
    }

    // 🔹 Agora é público para ser chamado pelo InputHandler
    public void UseSpecialAttack()
    {
        Debug.Log("Ataque Especial!");
        canUseSpecial = false;
        specialCooldownTimer = specialCooldown;
    }
}
