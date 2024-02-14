using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour 
{
    private int healingAmount;
    private List<PlayerCharacter> partyMembers;

    public void SetQuantityOfHealthPotion(int healingAmount)
    {
        this.healingAmount = healingAmount;
    }

    public void Use()
    {
        foreach (PlayerCharacter character in partyMembers)
        {
            character.ReceiveHealing(healingAmount);
        }
    }

    public int GetHealthPotionAmount()
    {
        return healingAmount;
    }
}