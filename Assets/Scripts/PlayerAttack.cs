using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float comboResetTime = 1f;
    private int comboCount = 0;
    private float lastAttackTime;

    void Update()
    {
        if (Time.time - lastAttackTime > comboResetTime)
        {
            comboCount = 0; // Reseta o combo
        }

        if (Input.GetKeyDown(KeyCode.Space)) // Troque por Input System para suporte ao joystick
        {
            PerformComboAttack();
        }
    }

    void PerformComboAttack()
    {
        comboCount++;
        lastAttackTime = Time.time;

        if (comboCount == 1)
        {
            Debug.Log("Golpe 1");
            // Adicione animação e som aqui
        }
        else if (comboCount == 2)
        {
            Debug.Log("Golpe 2");
            // Adicione animação e som aqui
        }
        else if (comboCount == 3)
        {
            Debug.Log("Golpe 3");
            // Adicione animação e som aqui
            comboCount = 0; // Reseta o combo
        }
    }
    public float specialCooldown = 5f;
private bool canUseSpecial = true;

void Update()
{
    if (Input.GetKeyDown(KeyCode.E) && canUseSpecial)
    {
        UseSpecialAttack();
    }
}

void UseSpecialAttack()
{
    Debug.Log("Ataque Especial!");
    canUseSpecial = false;
    StartCoroutine(SpecialCooldownRoutine());
}

IEnumerator SpecialCooldownRoutine()
{
    yield return new WaitForSeconds(specialCooldown);
    canUseSpecial = true;
}

}
