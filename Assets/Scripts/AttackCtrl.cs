using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class AttackCtrl : MonoBehaviour {

    public int enemy1num = 3;
    public int enemy2num = 1; //적 2의 총 수 

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "ENEMY")  //충돌한 대상이 적1태그를 가지고 있는 녀석이면
        {
            Destroy(coll.gameObject);   //그 충돌한 대상을 없앤다.
            enemy1num -= 1;  //적1 의 총 수 감소

        }
        else if (coll.collider.tag == "ENEMY2")
                {
            if(enemy1num==0)
            {
                Destroy(coll.gameObject);
                enemy2num -= 1; // 적 2의 총 수 감소
                Invoke("GotoClear", 2.0f);
}
            else
            {
                Destroy(this.gameObject);
            }

        }


    }

    void GotoClear() // 적2의 총 수가 0이 되었을 때 clear 화면 호출 차후 수정 필요 클리어 조건이 적 수 제거가 아니므로
    {
        if (enemy2num <= 0)
        {
            SceneManager.LoadScene("Clear");
        }

    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
