using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryExample.UI
{
    public class ShowHideUI : MonoBehaviour
    {
        [SerializeField] KeyCode togglePanelKey = KeyCode.Escape;
        [SerializeField] KeyCode toggleHammerKey = KeyCode.A;
        [SerializeField] GameObject uiPanelContainer = null;
        [SerializeField] GameObject uiHammerContainer = null;

        // Start is called before the first frame update
        void Start()
        {
            uiPanelContainer.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(togglePanelKey))
            {
                uiPanelContainer.SetActive(!uiPanelContainer.activeSelf);
            }

            if (Input.GetKeyDown(toggleHammerKey)) {
                uiHammerContainer.SetActive(!uiHammerContainer.activeSelf);
            }
        }
    }
}