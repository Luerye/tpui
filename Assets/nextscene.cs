using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
	public string nextSce = "AR Scanner";

public void LoadNextSce()
{
SceneManager.LoadScene(nextSce);
}
}
