using UnityEngine;

namespace NavigationDrawer.Controller
{
    public class MainController : MonoBehaviour

    {

        [SerializeField, Header("Controllers")]
        private NavDrawerController _navDrawerController;

        public MainController(NavDrawerController navDrawerController)
        {
            _navDrawerController = navDrawerController;
}

    private void Initialize()
    {
        _navDrawerController.InitNavDrawer();
    }

}
}
