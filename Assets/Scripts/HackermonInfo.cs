using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Scriptable Objects/HackermonInfo")]
public class HackermonInfo : ScriptableObject
{
    [SerializeField] string displayName;
    [TextArea] [SerializeField] string description;
    [SerializeField] Sprite sprite;
    [SerializeField] HackerType hackerType;

    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int speed;
    [SerializeField] List<MoveInfo> moves;
    
    public string DisplayName { get { return name; } }
    public string Description { get { return description; } }
    public int Attack { get { return attack; } }
    public int Defense { get { return defense; } }
    public int MaxHP {  get { return maxHP;  } }

    public List<MoveInfo> Moves {  get { return moves; } }
}

public enum HackerType
{
    Reconaissance,
    ResourceDevelopment,
    InitialAccess,
    Execution,
    Persistence,
    PrivelegeEscalation,
    DefenseEvasion,
    CredentialAccess,
    Discovery,
    LateralMovement,
    Collection,
    CommandAndControl,
    Exfiltration,
    Impact
}
