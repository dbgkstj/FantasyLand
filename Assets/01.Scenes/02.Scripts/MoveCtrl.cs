using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    private Transform camTr;
    private Transform tr;
    void Start()
    {
        //메인 카메라의 Transform 컴포넌트 추출
        camTr = Camera.main.GetComponent<Transform>();
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        //메인 카메라를 향해 Z축 회전
        tr.LookAt(camTr.position);
    }
}
