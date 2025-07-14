using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] Animator anicon_MushroomMan;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 입력
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        Vector3 moveDirection = new Vector3(moveX, 0, moveZ).normalized;

        // 이동
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // 회전
        // 입력값(moveDirection)이 0이 아닌 경우에는 움직이는 것으로 판단한다.
        // moveDirection이 0일때 = Idle 애니메이션
        // moveDirection이 0이 아닐때 = Walk 애니메이션
        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        }

        //애니메이터
        bool iswalk = 0 < moveDirection.magnitude;
        anicon_MushroomMan.SetBool("ISWALK", iswalk);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("공격!");
            anicon_MushroomMan.SetTrigger("ISATTACK");
        }
    }
}