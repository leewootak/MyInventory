using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Title;
    public string Name;
    public int Atk;
    public int Def;
    public int Hp;
    public int Cri;

    public Character(string title, string name, int atk, int def, int hp, int cri)
    {
        Title = title;
        Name = name;
        Atk = atk;
        Def = def;
        Hp = hp;
        Cri = cri;
    }
}
