using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class StageCtrl2 : MonoBehaviour {

    // Use this for initialization
    public void OnClicked()
    {
        SceneManager.LoadScene("stage2");
    }
}
