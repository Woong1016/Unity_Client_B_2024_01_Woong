using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExAccessControl : MonoBehaviour
{
    public int publicValue; // 퍼블릭으로 선언된 변수는 스크립트내에서 직접 접근 가능

    private int privateValue;//private로 선언된 변수는 

    protected int protectedValue;

    internal int internalValue;



}


public class ParentClass
{
    private int protectedValueParent;
}

public class ChildClass: ParentClass // ParentClass 상속
{
   void Start()
    {
        //Debug.Log(ProtectedValueParent);
    }

}
 
