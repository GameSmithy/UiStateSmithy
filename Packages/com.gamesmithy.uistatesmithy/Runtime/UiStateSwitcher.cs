namespace UiStateSmithy {

    public abstract class UiStateSwitcher {
        protected IInitialUiState InitialUiState;
        
        public void Initialize() {
            CreateStates();
            ActiveInitialState();
        }

        protected virtual void CreateStates() {
            throw new System.NotImplementedException();
        }
        
        private void ActiveInitialState() {
            InitialUiState.Show();
        }
    }
}