using System;
using UnityEngine;

namespace Combat
{
    public class Unit : MonoBehaviour
    {
        [SerializeField]
        private string name;

        [SerializeField]
        private int currentHp;

        [SerializeField]
        private int maxHp;

        [SerializeField]
        private int currentMp;

        [SerializeField]
        private int maxMp;

        [SerializeField]
        private int damage;

        [SerializeField]
        private int armor;

        public Unit(CreatureData data)
        {
            this.name = data.name;
            this.currentHp = data.maxHp;
            this.maxHp = data.maxHp;
            this.currentMp = data.maxMp;
            this.maxMp = data.maxMp;
            this.damage = data.damage;
            this.armor = data.armor;
        }

        public string getName()
        {
            return name;
        }

        public int getCurrentHp()
        {
            return currentHp;
        }

        public int getMaxHp()
        {
            return maxHp;
        }

        public int getCurrentMp()
        {
            return currentMp;
        }

        public int getMaxMp()
        {
            return maxMp;
        }

        public int getDamage()
        {
            return damage;
        }

        public int getArmor()
        {
            return armor;
        }
    }
}
