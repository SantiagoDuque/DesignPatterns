namespace Decorator
{
    public interface IFileProcessor
    {
        byte[] GetBytes(IFile file);
    }
}