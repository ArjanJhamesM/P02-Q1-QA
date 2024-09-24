using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayStats : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI PlayerOneField;
    [SerializeField] private TextMeshProUGUI PlayerTwoField;
    [SerializeField] private TextMeshProUGUI PlayerThreeField;

    private PlayerOneStats playerOne;
    private PlayerTwoStats playerTwo;
    private PlayerThreeStats playerThree;

    public void DisplayPlayerOneStats()
    {
        playerOne = new PlayerOneStats();

        PlayerOneField.text =
            "Health: " + playerOne.health +
            "\nDamage: " + playerOne.damage +
            "\nCrit Damage: " + playerOne.critDamage +
            "\nDefense: " + playerOne.defense;
    }

    public void DisplayPlayerTwoStats()
    {
        playerTwo = new PlayerTwoStats();

        PlayerTwoField.text =
            "Health: " + playerTwo.health +
            "\nDamage: " + playerTwo.damage +
            "\nCrit Damage: " + playerTwo.critDamage +
            "\nDefense: " + playerTwo.defense;
    }

    public void DisplayPlayerThreeStats()
    {
        playerThree = new PlayerThreeStats();

        PlayerThreeField.text =
            "Health: " + playerThree.health +
            "\nDamage: " + playerThree.damage +
            "\nCrit Damage: " + playerThree.critDamage +
            "\nDefense: " + playerThree.defense;
    }
}
