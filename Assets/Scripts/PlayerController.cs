using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float MoveSpeed;
    Vector3 lookDirection;

	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.LeftArrow)||
       Input.GetKey(KeyCode.RightArrow)||
       Input.GetKey(KeyCode.DownArrow)||
       Input.GetKey(KeyCode.UpArrow))                     //키보드 상하좌우를 누르면
        {
            float xx = Input.GetAxisRaw("Vertical");
            float zz = Input.GetAxisRaw("Horizontal");
            lookDirection = xx * Vector3.forward + zz * Vector3.right;  //상하좌우 값을 읽어들이고 이동하려는 위치 방향을 설정한다.

            this.transform.rotation = Quaternion.LookRotation (lookDirection);
            this.transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);

        }
            
	}
}
