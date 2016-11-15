using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{

	// Use this for initialization
	public void OnstartButtonClicked ()
    {
        SceneManager.LoadScene("main");
	}
   
}
