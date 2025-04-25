using UnityEngine;

public class Hackermon
{
    HackermonInfo info;
    int level;
    public int HP { get; set; }

    public Hackermon(HackermonInfo info, int level)
    {
        this.info = info;
        this.level = level;
        HP = info.MaxHP;
    }

    public int Attack
    {
        get { return Mathf.FloorToInt((info.Attack * level) / 100f) + 5; }
    }

    public int Defense
    {
        get { return Mathf.FloorToInt((info.Defense * level) / 100f) + 5; }
    }
    public int maxHP
    {
        get { return Mathf.FloorToInt((info.MaxHP * level) / 100f) + 10; }
    }
}
