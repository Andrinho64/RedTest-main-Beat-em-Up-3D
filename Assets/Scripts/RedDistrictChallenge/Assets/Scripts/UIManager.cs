using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image energyBar; // Reference to the energy bar UI element
    public float maxEnergy = 100f; // Maximum energy for special attacks
    private float currentEnergy; // Current energy level

void Start()
{
    if (energyBar == null)
    {
        energyBar = GameObject.Find("NomeDoObjetoEnergyBar")?.GetComponent<Image>();
        if (energyBar == null)
        {
            Debug.LogError("UIManager: Energy Bar não foi encontrado!");
        }
    }
    
    currentEnergy = maxEnergy;
    UpdateEnergyBar();
}


    public void UseSpecialEnergy(float amount)
    {
        currentEnergy -= amount; // Decrease energy when special attack is used
        UpdateEnergyBar();
    }

    public void RechargeEnergy(float amount)
    {
        currentEnergy += amount; // Recharge energy
        if (currentEnergy > maxEnergy)
        {
            currentEnergy = maxEnergy; // Cap energy at max
        }
        UpdateEnergyBar();
    }

    private void UpdateEnergyBar()
    {
        energyBar.fillAmount = currentEnergy / maxEnergy; // Update the UI energy bar
    }

    public void ShowSpecialReadyFeedback()
    {
        // Implement feedback for when special attack is ready (e.g., change color)
    }
}