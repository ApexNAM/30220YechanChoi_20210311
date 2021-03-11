using System.Collections; // 자료형 (using : import)
using System.Collections.Generic; // 제너릭
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour // Unity의 모든 스크립트가 상속받는 클래스.
{
    // 접근 제한자 목록
    // public : 모든 접근 허용
    // private : 같은 패키지에 있는 객체들만 허용
    // protected : 같은 패키지에 있는 객체, 상속관계의 객체만 허용

    string animal = "양";
    int count = 0;
    void Start()
    {
        Debug.Log("양 세우기 시작...");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError((count++)+ "마리"); // 에러로 양을 센다.
    }
}
