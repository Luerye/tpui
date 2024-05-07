using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    public Menus currentState;
    public Canvas mainMenuCanv;
    public Canvas loginMenuCanv;
    public Canvas loginMenu;
    public Canvas signupMenuCanv;
    public Canvas chooseLogGoogle;
    public Canvas chooseSignGoogle;
    public Canvas continueLogGoogle;
    public Canvas continueSignGoogle;
    public Canvas forgotPass;
    
    void Start()
    {
        currentState = Menus.MainMenu;
    }
    void Update()
    {
        if (Input.touchCount > 0) // Check for touch input
        {
            Touch touch = Input.GetTouch(0); // Get the first touch

            if (touch.phase == TouchPhase.Began) // Handle touch began event (similar to a button press)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position); // Cast a ray from the touch position
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit)) // Check if the raycast hits a UI element
                {
                    string buttonName = hit.collider.gameObject.name;
                    switch (buttonName)
                    {
                        case "Log In":
                            OnLoginButtonPressed();
                            break;
                        case "Sign Up":
                            OnSignupButtonPressed();
                            break;
                        case "Log in with Google":
                            OnChooseLogGButtonPressed();
                            break;
                        case "Sign Up with Google":
                            OnChooseSignGButtonPressed();
                            break;
                        case "Continue to Google Login Choose":
                            OnConLogGButtonPressed();
                            break;
                        case "Continue to Google Signup Choose":
                            OnConSignGButtonPressed();
                            break;
                        case "Forgot Password Button":
                            OnForgoPassButtonPressed();
                            break;
                        case "Log In Button":
                            OnLogInnButtonPressed();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }

    public void OnLoginButtonPressed()
    {
        currentState = Menus.Login;
        loginMenuCanv.gameObject.SetActive(true);
        loginMenu.gameObject.SetActive(true);
        mainMenuCanv.gameObject.SetActive(false);
        signupMenuCanv.gameObject.SetActive(false);
        chooseLogGoogle.gameObject.SetActive(false);
        chooseSignGoogle.gameObject.SetActive(false);
        continueLogGoogle.gameObject.SetActive(false);
        continueSignGoogle.gameObject.SetActive(false);
        forgotPass.gameObject.SetActive(false);
    }

    public void OnSignupButtonPressed()
    {
        currentState = Menus.SignUp;
        loginMenuCanv.gameObject.SetActive(true);
        loginMenu.gameObject.SetActive(false);
        mainMenuCanv.gameObject.SetActive(false);
        signupMenuCanv.gameObject.SetActive(true);
        chooseLogGoogle.gameObject.SetActive(false);
        chooseSignGoogle.gameObject.SetActive(false);
        continueLogGoogle.gameObject.SetActive(false);
        continueSignGoogle.gameObject.SetActive(false);
        forgotPass.gameObject.SetActive(false);
    }

    public void OnChooseLogGButtonPressed()
    {
        currentState = Menus.LogGoogleChoose;
        loginMenuCanv.gameObject.SetActive(true);
        loginMenu.gameObject.SetActive(false);
        mainMenuCanv.gameObject.SetActive(false);
        signupMenuCanv.gameObject.SetActive(false);
        chooseLogGoogle.gameObject.SetActive(true);
        chooseSignGoogle.gameObject.SetActive(false);
        continueLogGoogle.gameObject.SetActive(false);
        continueSignGoogle.gameObject.SetActive(false);
        forgotPass.gameObject.SetActive(false);
    }

    public void OnChooseSignGButtonPressed()
    {
        currentState = Menus.SignGoogleChoose;
        loginMenuCanv.gameObject.SetActive(true);
        loginMenu.gameObject.SetActive(false);
        mainMenuCanv.gameObject.SetActive(false);
        signupMenuCanv.gameObject.SetActive(false);
        chooseLogGoogle.gameObject.SetActive(false);
        chooseSignGoogle.gameObject.SetActive(true);
        continueLogGoogle.gameObject.SetActive(false);
        continueSignGoogle.gameObject.SetActive(false);
        forgotPass.gameObject.SetActive(false);
    }

    public void OnConLogGButtonPressed()
    {
        currentState = Menus.ContinueLogGoogle;
        loginMenuCanv.gameObject.SetActive(true);
        loginMenu.gameObject.SetActive(false);
        mainMenuCanv.gameObject.SetActive(false);
        signupMenuCanv.gameObject.SetActive(false);
        chooseLogGoogle.gameObject.SetActive(false);
        chooseSignGoogle.gameObject.SetActive(false);
        continueLogGoogle.gameObject.SetActive(true);
        continueSignGoogle.gameObject.SetActive(false);
        forgotPass.gameObject.SetActive(false);
    }

    public void OnConSignGButtonPressed()
    {
        currentState = Menus.ContinueSignGoogle;
        loginMenuCanv.gameObject.SetActive(true);
        loginMenu.gameObject.SetActive(false);
        mainMenuCanv.gameObject.SetActive(false);
        signupMenuCanv.gameObject.SetActive(false);
        chooseLogGoogle.gameObject.SetActive(false);
        chooseSignGoogle.gameObject.SetActive(false);
        continueLogGoogle.gameObject.SetActive(false);
        continueSignGoogle.gameObject.SetActive(true);
        forgotPass.gameObject.SetActive(false);
    }

    public void OnForgoPassButtonPressed()
    {
        currentState = Menus.ForgotPass;
        loginMenuCanv.gameObject.SetActive(true);
        loginMenu.gameObject.SetActive(false);
        mainMenuCanv.gameObject.SetActive(false);
        signupMenuCanv.gameObject.SetActive(false);
        chooseLogGoogle.gameObject.SetActive(false);
        chooseSignGoogle.gameObject.SetActive(false);
        continueLogGoogle.gameObject.SetActive(false);
        continueSignGoogle.gameObject.SetActive(false);
        forgotPass.gameObject.SetActive(true);
    }

    public void OnLogInnButtonPressed()
    {
        SceneManager.LoadScene(1);
    }
}
