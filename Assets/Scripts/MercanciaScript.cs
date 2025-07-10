using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;

     void Start()
    {
        if (moneyManager == null)
        {
            moneyManager = FindObjectOfType<MoneyManager>();
        }
      
    }

    public void Comprar()
    {
        if (moneyManager != null)
        {
            if (moneyManager.money >= cost)
            {
                moneyManager.UpdateMoney(-cost);
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("No tenes plata :(");
            }
        }
        else
        {
            Debug.LogWarning("MoneyManager no encontrado");
        }
    }
}
