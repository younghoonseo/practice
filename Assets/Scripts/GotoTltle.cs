using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GotoTltle : MonoBehaviour
{

	// Use this for initialization
	public void OnstartButtonClicked ()
    {
        SceneManager.LoadScene("title");
	}
   
}
