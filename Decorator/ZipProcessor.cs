using System;

namespace Decorator
{
    public class ZipProcessor : ProcessorDecorator
    {
        public ZipProcessor(IFileProcessor fileProcessor) 
            : base(fileProcessor)
        {
        }

        public override byte[] GetBytes(IFile file)
        {
            return _fileProcessor.GetBytes(DoMagic(file));
        }

        private IFile DoMagic(IFile file)
        {
            return file;
        }
    }
}