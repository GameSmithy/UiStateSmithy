using System.Collections.Generic;

namespace UiStateSmithy.Samples.States {

    public class MetaUiState : BaseUiState {
        public MetaUiState(UiStateSwitcher uiStateSwitcher) : base(uiStateSwitcher) {
            UiStateName = UiStateType.Meta.ToString();
            AllowedPaths = new HashSet<string> {UiStateType.Shop.ToString()};
        }
    }
}
