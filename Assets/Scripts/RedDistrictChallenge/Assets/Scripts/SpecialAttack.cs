using UnityEngine;
using UnityEngine.UI;

public class SpecialAttack : MonoBehaviour
{
    public float specialCooldown = 5f;
    private float nextSpecialAttackTime = 0f;
    public Image energyBar; // Reference to the UI energy bar
    private bool canUseSpecial = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canUseSpecial)
        {
            UseSpecialAttack();
        }

        // Update the energy bar UI
        if (!canUseSpecial)
        {
            UpdateEnergyBar();
        }
    }

    void UseSpecialAttack()
    {
        Debug.Log("Special Attack Executed!");
        // Add animation and sound here

        canUseSpecial = false;
        nextSpecialAttackTime = Time.time + specialCooldown;
    }

    void UpdateEnergyBar()
    {
        float remainingTime = nextSpecialAttackTime - Time.time;
        if (remainingTime <= 0)
        {
            canUseSpecial = true;
            energyBar.fillAmount = 1f; // Reset energy bar
        }
        else
        {
            energyBar.fillAmount = remainingTime / specialCooldown; // Update energy bar
        }
    }
}