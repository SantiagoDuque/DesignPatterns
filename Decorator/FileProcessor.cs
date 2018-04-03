namespace Decorator
{
    public class FileProcessor : IFileProcessor
    {
        public byte[] GetBytes(IFile file)
        {
            return new byte[] { 1, 1, 0, 1, 8 };
        }
    }
}