namespace UiStateSmithy.Samples.States {

    public class ShopUiState : BaseUiState {
        public ShopUiState(UiStateSwitcher uiStateSwitcher) : base(uiStateSwitcher) {
            UiStateName = UiStateType.Shop.ToString();
        }
    }
}
