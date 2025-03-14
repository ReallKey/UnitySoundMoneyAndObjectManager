using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Make sure you add this line for the Text component

public class MoneyManager : MonoBehaviour
{
    public static float Money = 155;
    public static float CostOfButtonOne = 50;

    public Text text; 

    private void Start() {
       
    }

    private void Update() {
        // Display money in the UI
        text.text = "You Have " + Money + "$";
    }

    public static bool MoneyChecker(float MoneyAmount) {
        return Money >= MoneyAmount;
    }

    public static void MoneySubtracter(float MoneyAmount) {
        Money -= MoneyAmount;
    }

    public static float CostGetter() {
        return CostOfButtonOne;
    }
}
