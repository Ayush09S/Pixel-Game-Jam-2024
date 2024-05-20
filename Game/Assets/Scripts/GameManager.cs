using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public CharacterController controller;
    public TextMeshProUGUI fishNum;
    public TextMeshProUGUI money;
    public GameObject fishPrefab;

    // Start is called before the first frame update
    void Start()
    {
        fishNum.text = "Fish Collected: 0";
        money.text = "Money: $0";
    }

    // Update is called once per frame
    void Update()
    {
        fishNum.text = $"Fish Collected: {CharacterController.fishes}";
        money.text = $"Money: ${controller.money}";
    }
    public void sellAll()
    {
        if (CharacterController.fishes > 0)
        {
            controller.money += CharacterController.fishes;
            CharacterController.fishes -= CharacterController.fishes;
            Instantiate(fishPrefab);
        }
    }
    public void ExitGame()
    {
        // Close the WebGL application (open a blank page to simulate closing)
        Application.OpenURL("about:blank");
    }

}
