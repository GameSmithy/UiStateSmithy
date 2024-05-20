using System.Collections.Generic;

namespace UiStateSmithy.Samples.States {
    public class InitUiState : BaseUiState {
        public InitUiState(UiStateSwitcher uiStateSwitcher) : base(uiStateSwitcher) {
            UiStateName = UiStateType.Init.ToString();
            AllowedPaths = new HashSet<string> {UiStateType.Loading.ToString()};
        }

        protected override void OnShown() {
            base.OnShown();
            MoveToLoadingState();
        }

        
        //Should be in generated partial class
        private void MoveToLoadingState() {
            UiStateSwitcher.MoveToState(UiStateType.Loading.ToString());
        }
    }
}
