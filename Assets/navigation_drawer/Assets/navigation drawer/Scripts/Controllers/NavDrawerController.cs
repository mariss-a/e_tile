using NavigationDrawer.UI;
using UnityEngine;
using UnityEngine.UI;

namespace NavigationDrawer.Controller
{
    public class NavDrawerController : MonoBehaviour
    {
        [SerializeField, Header("Nav panels")]
        public NavDrawerPanelController _navDrawerPanelController;

        [SerializeField]
        public NavDrawerPanel _navDrawerPanel;

        [SerializeField, Header("Nav buttons")]
        public Button _btnNew;

        [SerializeField]
        public Button _btnMostUsed;

        [SerializeField]
        public Button _btnTileCalculator;

        [SerializeField]
        public Button _btnAbout;

        [SerializeField]
        public Button _btnExit;

        private void Start()
        {
            _btnNew.onClick.AddListener(NavDrawerPanelOnNew);
            _btnMostUsed.onClick.AddListener(NavDrawerPanelOnMostUsed);
            _btnTileCalculator.onClick.AddListener(NavDrawerPanelOnTileCalculator);
            _btnAbout.onClick.AddListener(NavDrawerPanelOnAbout);
            _btnExit.onClick.AddListener(NavDrawerPanelOnExit);
        }

        public void InitNavDrawer()
        {
            _navDrawerPanel.Open();
        }

        public void CloseAllPanel()
        {
            _navDrawerPanelController.CloseAllPanel();
        }

        private void NavDrawerPanelOnNew()
        {
            _navDrawerPanelController.OpenNewPanel();
        }

        private void NavDrawerPanelOnMostUsed()
        {
            _navDrawerPanelController.OpenMostUsedPanel();
        }

        private void NavDrawerPanelOnTileCalculator()
        {
            _navDrawerPanelController.OpenTileCalculatorPanel();
        }

        private void NavDrawerPanelOnAbout()
        {
            _navDrawerPanelController.OpenAboutPanel();
        }

        private void NavDrawerPanelOnExit()
        {
            _navDrawerPanelController.OpenExitPanel();
        }
    }
}
