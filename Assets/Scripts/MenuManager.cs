using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MenuManager
{

    public static bool IsInitialized { get; private set; }
    public static GameObject mainMenu, loginMenu;

    public static void Init()
    {
        GameObject canvas = GameObject.Find("Main");
        mainMenu = canvas.transform.Find("Login and Sign Up Menu").gameObject;
        loginMenu = canvas.transform.Find("Login").gameObject;

        IsInitialized = true;
    }

    public static void OpenMenu(Menus menu, GameObject callingMenu)
    {
        if (!IsInitialized)
            Init();
        switch (menu)
        {
            case Menus.MainMenu:
                mainMenu.SetActive(true);
                break;
            case Menus.Login:
                loginMenu.SetActive(true);
                break;
        }

        callingMenu.SetActive(false);
    }

}