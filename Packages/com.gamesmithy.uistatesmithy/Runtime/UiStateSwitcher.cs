using System.Collections.Generic;

namespace UiStateSmithy {

    public abstract class UiStateSwitcher {
        protected BaseUiState InitialUiState;
        protected Dictionary<string, BaseUiState> states = new();
        private BaseUiState currentState;
        private string currentStateName;
        
        public void Initialize() {
            CreateStates();
            ActiveInitialState();
        }
        
        public void SetCurrentState(string stateName) {
            currentStateName = stateName;
            currentState = states[stateName];
        }

        public void MoveToState(string stateName) {
            if (stateName == currentStateName) {
                return;
            }
            
            var nextState = states[stateName];
            
            if (currentState == null) {
                nextState.Show();
            }
            else {
                if (!currentState.IsPathAllowed(stateName)) {
                    return;
                }
                
                currentState.Hide();
                nextState.Show();
            }
            
            currentState = nextState;
        }
        
        protected virtual void CreateStates() {
        }
        
        private void ActiveInitialState() {
            InitialUiState.Show();
        }
    }
}