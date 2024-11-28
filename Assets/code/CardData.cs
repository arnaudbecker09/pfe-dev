using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public int attack;
    public int defense;
    public string description;
    public Sprite artwork;
}
