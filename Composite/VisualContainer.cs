using System.Collections.Generic;

namespace Composite
{
    internal class VisualContainer : IVisualComponent
    {
        private readonly ICollection<IVisualComponent> _visualComponents = new HashSet<IVisualComponent>();
        public void Add(IVisualComponent visualComponent)
        {
            _visualComponents.Add(visualComponent);
        }

        public void Remove(IVisualComponent visualComponent)
        {
            _visualComponents.Remove(visualComponent);
        }

        public void Show()
        {
            foreach (var visualComponent in _visualComponents)
            {
                visualComponent.Show();
            }
        }
    }
}