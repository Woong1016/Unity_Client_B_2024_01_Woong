using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExAccessControl : MonoBehaviour
{
    public int publicValue; // �ۺ����� ����� ������ ��ũ��Ʈ������ ���� ���� ����

    private int privateValue;//private�� ����� ������ 

    protected int protectedValue;

    internal int internalValue;



}


public class ParentClass
{
    private int protectedValueParent;
}

public class ChildClass: ParentClass // ParentClass ���
{
   void Start()
    {
        //Debug.Log(ProtectedValueParent);
    }

}
 
