using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToStatusButton : MonoBehaviour
{

    private Button toStatusButton;

    private void Start()
    {
        ToStatusBtn();
    }

    private void ToStatusBtn()
    {

        Transform transformButton = transform.Find("StatusButton");

        if (transformButton != null)
        {
            toStatusButton = transformButton.GetComponent<Button>();
            
            if (toStatusButton != null)
            {
                toStatusButton.onClick.AddListener(ToStatus); //AddListener 공부할 것
            }
        }

        
    }
    public void ToStatus()
    {
        GameManager.Instance.OpenUiStatus();
        GameManager.Instance.CloseUiToStatus();
        GameManager.Instance.CloseUiToInventory();
    }

}
