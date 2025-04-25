using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/MoveInfo")]
public class MoveInfo : ScriptableObject
{
    [SerializeField] string displayName;
    [TextArea] [SerializeField] string description;
    [SerializeField] HackerType moveType;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;

    public string DisplayName { get { return displayName; } }
    public int Power { get { return power;  } }
    public int Accuracy { get { return accuracy; } }
    public int PP {  get { return pp; } }
}
