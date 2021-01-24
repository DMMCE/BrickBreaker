using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenuController : MonoBehaviour
{
    [SerializeField]
    GameObject ShopPanel;
    public void ShowShop(bool show)
    {
        ShopPanel.SetActive(show);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
