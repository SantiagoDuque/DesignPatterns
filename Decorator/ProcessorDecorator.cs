using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class ProcessorDecorator: IFileProcessor
    {
        protected readonly IFileProcessor _fileProcessor;
        protected ProcessorDecorator(IFileProcessor fileProcessor)
        {
            _fileProcessor = fileProcessor;
        }

        public abstract byte[] GetBytes(IFile file);
    }
}
