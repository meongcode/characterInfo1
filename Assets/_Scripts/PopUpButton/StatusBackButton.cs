using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusBackButton : MonoBehaviour
{

    private Button statusBackButton; 
    void Start()
    {
        StatusBackBtn();
    }
    private void StatusBackBtn()
    {


        Transform transformButton = transform.Find("StatusPopUp/StatusBackButton");

        if (transformButton != null)
        {
            statusBackButton = transformButton.GetComponent<Button>();
            if (statusBackButton != null)
            {
                statusBackButton.onClick.AddListener(StatusToMenuButton); 
            }
        }
    }
    public void StatusToMenuButton()
    {
        GameManager.Instance.CloseUiStatus();
        GameManager.Instance.OpenUiToStatus();
        GameManager.Instance.OpenUiToInventory();
    }
}
