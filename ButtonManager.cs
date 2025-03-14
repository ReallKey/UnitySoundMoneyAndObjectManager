using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject CantBuy;
    public GameObject canBuy;

     public List<GameObject> CanBuyObjects;
     public List<GameObject> CantBuyObjects;
     public List<GameObject> LineImage;
    void Start()
    {
        
    }
    
    public void ChangeToCantBuy(int ListNumber) {
        CantBuyObjects[ListNumber-1].SetActive(true);
        CanBuyObjects[ListNumber-1].SetActive(false);

    }

    public void CheckForMoney(int ListNumber) {
        if(MoneyManager.MoneyChecker(MoneyManager.CostOfButtonOne)) {
            ChangeToCantBuy(ListNumber);
            ActivateNextSection(ListNumber);
            MoneyManager.MoneySubtracter(MoneyManager.CostOfButtonOne);        
      }
      
    }
    public void ActivateNextSection(int ListNumber){
        CanBuyObjects[ListNumber].SetActive(true);
        LineImage[ListNumber].SetActive(true);
    }
}
