using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{

	// Use this for initialization
	public void OnClicked ()
    {
        SceneManager.LoadScene("Title");
	
	}
}
