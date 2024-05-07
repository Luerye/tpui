using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryMenuManager : MonoBehaviour
{
    public static TryMenuManager Instance;

    public Canvas HomePage;
    public GameObject Home;
    public GameObject FAQSMENU;
    public GameObject Settings;
    public GameObject Collections;
    public GameObject UserAccountPage;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if (Instance != null)
        {
            Destroy(this);
        }
    }

    public void HomeScreen()
    {
        Home.SetActive(true);
        FAQSMENU.SetActive(false);
        Settings.SetActive(false);
        Collections.SetActive(false);
        UserAccountPage.SetActive(false);
    }
    public void FaqsScreen()
    {
        Home.SetActive(false);
        FAQSMENU.SetActive(true);
        Settings.SetActive(false);
        Collections.SetActive(false);
        UserAccountPage.SetActive(false);
    }
    public void SettingsScreen()
    {
        Home.SetActive(false);
        FAQSMENU.SetActive(false);
        Settings.SetActive(true);
        Collections.SetActive(false);
        UserAccountPage.SetActive(false);
    }
    public void CollectionsScreen()
    {
        Home.SetActive(false);
        FAQSMENU.SetActive(false);
        Settings.SetActive(false);
        Collections.SetActive(true);
        UserAccountPage.SetActive(false);
    }
    public void UAPScreen()
    {
        Home.SetActive(false);
        FAQSMENU.SetActive(false);
        Settings.SetActive(false);
        Collections.SetActive(false);
        UserAccountPage.SetActive(true);
    }
}
