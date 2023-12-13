using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToInventoryButton : MonoBehaviour
{

    private Button toInventoryButton;

    void Start()
    {
        ToInventoryBtn();
    }

    private void ToInventoryBtn()
    {

        Transform transformButton = transform.Find("InventoryButton");

        if (transformButton != null)
        {
            toInventoryButton = transformButton.GetComponent<Button>();

            if (toInventoryButton != null)
            {
                toInventoryButton.onClick.AddListener(ToInventory);
            }

        }

            
    }
    public void ToInventory()
    {
        GameManager.Instance.OpenUiInventory();
        GameManager.Instance.CloseUiToStatus();
        GameManager.Instance.CloseUiToInventory();
    }


}
