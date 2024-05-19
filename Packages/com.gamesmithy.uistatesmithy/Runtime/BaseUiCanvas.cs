using UnityEngine;

namespace UiStateSmithy {

    public class BaseUiCanvas {
        private Canvas canvas;
        
        public void Show(int sortingOrder = 0) {
            canvas.sortingOrder = sortingOrder;
            canvas.enabled = true;
        }
        
        public void Hide() {
            canvas.enabled = false;
        }
    }
}