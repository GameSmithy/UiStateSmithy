using UnityEngine;

namespace UiStateSmithy.Samples.States {
    public class InitUiState : BaseUiState, IInitialUiState {
        public InitUiState(UiStateSwitcher uiStateSwitcher) : base(uiStateSwitcher) {
            Canvases = new BaseUiCanvas[] {
            };
        }

        public void Show() {
            Debug.Log($"{this.GetType().Name} showing from InitUiState");
            ShowCanvases();
        }
    }
}
