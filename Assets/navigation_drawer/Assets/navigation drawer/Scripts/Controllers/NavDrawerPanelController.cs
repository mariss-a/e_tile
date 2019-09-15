using System.Collections;
using NavigationDrawer.UI;
using UnityEngine;

namespace NavigationDrawer.Controller
{
    public class NavDrawerPanelController : MonoBehaviour
    {
        [SerializeField, Header("Panels")]
        private NewPanel _newPanel;
        
        [SerializeField]
        private MostUsedPanel _mostusedPanel;

        [SerializeField]
        private AboutPanel _aboutPanel;

        [SerializeField]
        private ExitPanel _exitPanel;

        [SerializeField]
        private TileCalculatorPanel _tilecalculatorPanel;

        [SerializeField]
        private GameObject _btnMenu;

        public NavDrawerPanelController(NewPanel newPanel, MostUsedPanel mostusedPanel, AboutPanel aboutPanel, ExitPanel exitPanel, TileCalculatorPanel tilecalculatorPanel, GameObject btnMenu)
        {
            _newPanel = newPanel;
            _mostusedPanel = mostusedPanel;
            _aboutPanel = aboutPanel;
            _exitPanel = exitPanel;
            _tilecalculatorPanel = tilecalculatorPanel;
            _btnMenu = btnMenu;
        }

        public void OpenNewPanel()
        {
            OpenWindow(_newPanel.gameObject);
        }

        public void OpenMostUsedPanel()
        {
            OpenWindow(_mostusedPanel.gameObject);
        }

        public void OpenTileCalculatorPanel()
        {
            OpenWindow(_tilecalculatorPanel.gameObject);
        }

        public void OpenAboutPanel()
        {
            OpenWindow(_aboutPanel.gameObject);
        }

        public void OpenExitPanel()
        {
            OpenWindow(_exitPanel.gameObject);
        }

        public void SetActiveBtnMenu(bool value)
        {
            _btnMenu.SetActive(value);
        }

        public void CloseAllPanel()
        {
            if (_newPanel.isActiveAndEnabled)
            {
                CloseWindow(_newPanel.gameObject);
            }

            if (_mostusedPanel.isActiveAndEnabled)
            {
                CloseWindow(_mostusedPanel.gameObject);
            }

            if (_tilecalculatorPanel.isActiveAndEnabled)
            {
                CloseWindow(_tilecalculatorPanel.gameObject);
            }

            if (_exitPanel.isActiveAndEnabled)
            {
                CloseWindow(_exitPanel.gameObject);
            }

            if (_aboutPanel.isActiveAndEnabled)
            {
                CloseWindow(_aboutPanel.gameObject);
            }
        }

        private static void CloseWindow(GameObject popup)
        {
            popup.GetComponent<Popup>().CloseWindow();
        }

        private void OpenWindow(GameObject popup)
        {
            StartCoroutine(OpenWindowAsync(popup));
        }

        private static IEnumerator OpenWindowAsync(GameObject popup)
        {
            yield return new WaitForSeconds(0.25f);

            popup.SetActive(true);
            popup.transform.localScale = Vector3.one;
            popup.GetComponent<Popup>().Open();
        }
    }
}
