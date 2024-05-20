using System;
using System.Collections.Generic;
using UnityEngine;

namespace UiStateSmithy {
    public class BaseUiState {
        protected readonly UiStateSwitcher UiStateSwitcher;
        protected BaseUiCanvas[] Canvases = Array.Empty<BaseUiCanvas>();
        protected HashSet<string> AllowedPaths = new();
        
        protected string UiStateName;
        
        protected BaseUiState(UiStateSwitcher uiStateSwitcher) {
            this.UiStateSwitcher = uiStateSwitcher;
            
            UiStateName = string.Empty;
            
            Debug.Log($"{this.GetType().Name} created.");
        }
        
        public bool IsPathAllowed(string path) {
            return AllowedPaths.Contains(path);
        }
        
        public void Show() {
            Debug.Log($"{this.GetType().Name} showing from InitUiState");
            UiStateSwitcher.SetCurrentState(UiStateName);
            
            OnShowing();
            ShowCanvases();
            OnShown();
        }

        public void Hide() {
            Debug.Log($"{this.GetType().Name} hiding from InitUiState");
            
            OnHiding();
            HideCanvases();
            OnHidden();
        }

        protected virtual void OnShowing() {
            Debug.Log($"{this.GetType().Name} OnShowing");
        }

        protected virtual void OnHiding() {
            Debug.Log($"{this.GetType().Name} OnHiding");
        }

        protected virtual void OnShown() {
            Debug.Log($"{this.GetType().Name} OnShown");
        }

        protected virtual void OnHidden() {
            Debug.Log($"{this.GetType().Name} OnHidden");
        }

        private void HideCanvases() {
            foreach (var t in Canvases) {
                t.Hide();
            }
        }
        
        private void ShowCanvases() {
            Debug.Log($"{this.GetType().Name} showing.");
            for (var i = 0; i < Canvases.Length; i++) {
                Canvases[i].Show(i);
            }
        }
    }
}