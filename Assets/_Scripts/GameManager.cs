using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject uiCanvasPrefab;
    [SerializeField] private GameObject uiStatusPrefab;
    [SerializeField] private GameObject uiInventoryPrefab;
    [SerializeField] private GameObject uiToStatusPrefab;
    [SerializeField] private GameObject uiToInventoryPrefab;
    [SerializeField] private GameObject eventSystem;
    [SerializeField] private GameObject equipCheckCanvasPrefab;

    private GameObject uiStatus;
    private GameObject uiInventory;
    private GameObject uiToStatus;
    private GameObject uiToInventory;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        CreateUICanvas();
        CreateEventSystem();
        CreateUIStatus();
        CreateUIInventory();
        CreateUIToStatus();
        CreateUIToInventory();
        CreateEquipCheckCanvas();
    }
    
    #region CreateUI
    private void CreateUICanvas()
    {
        if (uiCanvasPrefab != null)
        {
            Instantiate(uiCanvasPrefab);
        }
    }

    private void CreateEventSystem()
    {
        Instantiate(eventSystem);
    }
    private void CreateUIStatus()
    {
        if (uiStatusPrefab != null)
        {
            uiStatus = Instantiate(uiStatusPrefab);
        }
    }
    private void CreateUIInventory()
    {
        if (uiInventoryPrefab != null)
        {
            uiInventory = Instantiate(uiInventoryPrefab);
        }
    }
    private void CreateUIToStatus()
    {
        if (uiToStatusPrefab != null)
        {
            uiToStatus = Instantiate(uiToStatusPrefab);
        }
    }
    private void CreateUIToInventory()
    {
        if (uiToInventoryPrefab != null)
        {
            uiToInventory = Instantiate(uiToInventoryPrefab);
        }
    }

    private void CreateEquipCheckCanvas()
    {
        
        Instantiate(equipCheckCanvasPrefab);
        
    }
    #endregion

    #region OpenUI
    public void OpenUiStatus()
    {
        uiStatus.SetActive(true);
    }
    public void CloseUiStatus()
    {
        uiStatus.SetActive(false);
    }

    public void OpenUiInventory()
    {
        uiInventory.SetActive(true);
    }
    public void CloseUiInventory()
    {
        uiInventory.SetActive(false);
    }

    public void OpenUiToStatus()
    {
        uiToStatus.SetActive(true);
    }
    public void CloseUiToStatus()
    {
        uiToStatus.SetActive(false);
    }

    public void OpenUiToInventory()
    {
        uiToInventory.SetActive(true);
    }
    public void CloseUiToInventory()
    {
        uiToInventory.SetActive(false);
    }
    
    #endregion
}
