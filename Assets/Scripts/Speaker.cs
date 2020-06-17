using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Speaker", menuName ="Speaker/Dialogue")]
public class Speaker : ScriptableObject
{
    public string sentence;
    public Sprite avatar;
}
