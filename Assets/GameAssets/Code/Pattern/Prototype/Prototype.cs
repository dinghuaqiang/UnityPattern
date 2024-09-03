using Code.Pattern.Prototype;
using UnityEngine;
using UnityEngine.Profiling;

/// <summary>
/// ԭ��ģʽ����
/// </summary>
public class Prototype : MonoBehaviour
{
    void Start()
    {
        Profiler.BeginSample("Prototype s1");
        ServerInfo s1 = new ServerInfo();
        s1.IP = "192.168.0.1";
        s1.Port = 1008;
        s1.ID = 0;
        s1.Name = "New Server";
        s1.Description = "TestServer";
        Profiler.EndSample();
        //s1.Log();

        //TODO ���ﻹ����48B��GC �е�û��
        Profiler.BeginSample("Prototype s2");
        ServerInfo s2 = s1.Clone() as ServerInfo;
        s2.IP = "192.168.0.2";
        Profiler.EndSample();
        //s2.Log();
    }

    /*void Update()
    {
        
    }*/
}
