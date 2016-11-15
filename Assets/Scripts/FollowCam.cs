using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

    public Transform targetTr;  //추적할 타깃 게임오브젝트(플레이어)의 트렌스폼 변수
    public float dist = 10.0f;// 카메라와의 일정 거리
    public float height = 3.0f;// 카메라와의 일정 높이
    public float dampTrace = 20.0f; //부드러운 추적을 위한 변수

    private Transform tr;  //카메라 자신에 트랜스폼 변수 


	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>(); //카메라 자신의 트랜스폼 컴포넌트를 tr에 할당

	
	}
	
	// Update is called once per frame
	void LateUpdate () {
       // tr.position = Vector3.Lerp(tr.position, targetTr.position - (targetTr.forward * dist) + (Vector3.up * height),
         //   Time.deltaTime * dampTrace);  
        //부드러운 움직임을 위하여 Vector3.Lerp(a,b,c)라고 했을 때 a는 시작 위치,b는 종료위치,c는 보간시간(두 위치이동간 걸리는시간)인데 저희는 20으로 설정해놔서 좀더 부드럽게 움직이게 됩니다.

        tr.LookAt(targetTr.position); //카메라가 타겟오브젝트(플레이어)를 바라보게 설정
	
	}
}
