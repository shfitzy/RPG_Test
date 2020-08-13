using UnityEngine;
using UnityEngine.UI;

namespace CombatSystem
{
    public class CombatUI : MonoBehaviour
    {
        [SerializeField]
        private Button testButton;

        public void DisablePlayerUI()
        {
            testButton.interactable = false;
        }

        public void EnablePlayerUI()
        {
            testButton.interactable = true;
        }
    }
}
