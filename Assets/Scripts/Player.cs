using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players
{
    private string playerName;
    private int level = 1;

    public Players(string _name)
    {
        this.playerName = _name;
    }
    public void GetInfo()
    {
        Debug.Log("이름 : " + this.playerName);
        Debug.Log("레벨 : " + this.level);
    }

    public void LevelUp()
    {
        this.level++;
        Debug.Log("레벨 업!");
    }
}

public class Player : MonoBehaviour
{
    private void Start()
    {
        Players players = new Players("최예찬");
        players.GetInfo();
    }
}
