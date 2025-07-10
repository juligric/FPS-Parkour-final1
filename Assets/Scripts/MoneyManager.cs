using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        if(uiManager == null)
        {
            uiManager.UpdateMoneyTxt(money.ToString());
            if(uiManager == null)
            {
                Debug.LogWarning("UIManager no asignado en Money Manager y no se encontro en la escena.");
            }
        }
        uiManager?.UpdateMoneyTxt(money.ToString());
    }

    public void UpdateMoney(float moneyToAdd)
    {

        if (money + moneyToAdd < 0)
        {
            Debug.Log("No te alcanza");
            return;
        }
        money += moneyToAdd;
        if(uiManager == null)
        {
            uiManager = FindObjectOfType<UIManager>();
        }
        uiManager.UpdateMoneyTxt(money.ToString());
    }
}
