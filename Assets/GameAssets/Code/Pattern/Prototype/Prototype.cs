using Code.Pattern.Prototype;
using UnityEngine;
using UnityEngine.Profiling;

/// <summary>
/// 原型模式测试
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

        //TODO 这里还是有48B的GC 有点没懂
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
