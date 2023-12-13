using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryBackButton : MonoBehaviour
{

    private Button inventoryBackButton; 
    void Start()
    {
        InventoryBackBtn();
    }
    private void InventoryBackBtn()
    {

        Transform transformButton = transform.Find("InventoryPopUp/InventoryBackButton");
        if (transformButton != null)
        {
            inventoryBackButton = transformButton.GetComponent<Button>();
            if (inventoryBackButton != null)
            {
                inventoryBackButton.onClick.AddListener(InventoryToMenuButton);
            }

        }


        
    }
    public void InventoryToMenuButton()
    {
        GameManager.Instance.CloseUiInventory();
        GameManager.Instance.OpenUiToStatus();
        GameManager.Instance.OpenUiToInventory();
    }


}
