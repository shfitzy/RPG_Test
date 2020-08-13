using UnityEngine;

[CreateAssetMenu(fileName="New Unit", menuName="Combat Unit")]
public class Actor : ScriptableObject
{
    public new string name;
    public int maxHp;
    public int maxMp;
    public int damage;
    public int armor;

    public Sprite sprite;
}
