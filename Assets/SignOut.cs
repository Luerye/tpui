using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SignOut : MonoBehaviour
{
    [SerializeField]
    public Button signOutButton; // Reference your button in the inspector

    void Start()
    {
        signOutButton.onClick.AddListener(SignOutAndLoadLogin);
    }

    public void SignOutAndLoadLogin()
    {
       // Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
       // auth.SignOut();
        SceneManager.LoadScene("Login 1");
    }
}
