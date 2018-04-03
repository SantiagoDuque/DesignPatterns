using System;

namespace Decorator
{
    public static class Client
    {
        public static void Example()
        {
            IFileProcessor fileProcessor = new FileProcessor();

            IFile file = new File();

            fileProcessor.GetBytes(file);

            IFileProcessor fileCryptoProcesor = new CryptoProcessor(fileProcessor);
            fileCryptoProcesor.GetBytes(file);

            IFileProcessor fileCryptoZipProcesor = new ZipProcessor(fileCryptoProcesor);
            fileCryptoZipProcesor.GetBytes(file);

            IFileProcessor fileZipCryptoProcesor = new CryptoProcessor(new ZipProcessor(fileProcessor));
            fileZipCryptoProcesor.GetBytes(file);
        }
    }
}
