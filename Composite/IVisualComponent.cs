namespace Composite
{
    internal interface IVisualComponent
    {
        void Add(IVisualComponent visualComponent);
        void Remove(IVisualComponent visualComponent);
        void Show();
        
    }
}