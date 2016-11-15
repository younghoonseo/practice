using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class StageCtrl : MonoBehaviour {

    // Use this for initialization
    public void OnClicked()
    {
        SceneManager.LoadScene("stage1");
    }
}
