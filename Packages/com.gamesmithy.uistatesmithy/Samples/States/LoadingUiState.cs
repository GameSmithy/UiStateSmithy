using System.Collections.Generic;

namespace UiStateSmithy.Samples.States {

    public class LoadingUiState : BaseUiState {
        public LoadingUiState(UiStateSwitcher uiStateSwitcher) : base(uiStateSwitcher) {
            UiStateName = UiStateType.Loading.ToString();
            AllowedPaths = new HashSet<string> {UiStateType.Meta.ToString()};
        }
    }
}
