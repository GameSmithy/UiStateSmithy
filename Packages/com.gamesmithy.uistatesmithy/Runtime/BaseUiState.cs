using System;
using UnityEngine;

namespace UiStateSmithy {
    public class BaseUiState {
        protected readonly UiStateSwitcher UiStateSwitcher;
        protected BaseUiCanvas[] Canvases = Array.Empty<BaseUiCanvas>();

        public BaseUiState(UiStateSwitcher uiStateSwitcher) {
            this.UiStateSwitcher = uiStateSwitcher;
            Debug.Log($"{this.GetType().Name} created.");
        }

        protected void ShowCanvases() {
            Debug.Log($"{this.GetType().Name} showing.");
            for (var i = 0; i < Canvases.Length; i++) {
                Canvases[i].Show(i);
            }
        }
    }
}