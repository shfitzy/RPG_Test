using System;
using UnityEngine;

namespace Com.InfallibleCode.TurnBasedGame
{
    [CreateAssetMenu]
    public class Fighter : ScriptableObject
    {
        /*[SerializeField] private string _name;
        [SerializeField] private int _level;
        [SerializeField] private Color _color;
        [SerializeField] private int _currentHealth;
        [SerializeField] private int _totalHealth;
        [SerializeField] private int _attack;
        [SerializeField] private int _healing;*/

        public string Name;
        public int Level;
        public Color Color;
        public int CurrentHealth;
        public int TotalHealth;
        public int Attack;
        public int Healing;

        public bool Damage(int amount)
        {
            CurrentHealth = Math.Max(0, CurrentHealth - amount);
            return CurrentHealth == 0;
        }

        public void Heal(int amount)
        {
            CurrentHealth += amount;
        }

        private void OnValidate()
        {
            CurrentHealth = Math.Min(CurrentHealth, TotalHealth);
        }
    }
}