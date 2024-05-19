using UnityEngine;

namespace UiStateSmithy.Samples {
    public class Starter : MonoBehaviour {
        private UiStateSwitcherSample uiStateSwitcherSample;

        private void Awake() {
            uiStateSwitcherSample = new UiStateSwitcherSample();
            uiStateSwitcherSample.Initialize();
        }
    }
}
