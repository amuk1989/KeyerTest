using Grace.DependencyInjection;
using KeyerTest.CleanColor;
using KeyerTest.ImageHandler;

namespace KeyerTest.Di;

public static class DiInitializer
{
    public static DependencyInjectionContainer Container { get; private set; }//Bad solution
    public static void DiInitialize()
    {
        Container = new DependencyInjectionContainer();

        Container.Configure(c =>
        {
            c.Export<FileImageProvider>().As<IImageProvider>();
            c.Export<FileLoader>().As<FileLoader>();
            c.Export<ImageColorService>().As<IImageColorService>();
        });
        
        var imageProvider = Container.Locate<IImageProvider>();
        var fileLoader = Container.Locate<FileLoader>();
        var imageService = Container.Locate<IImageColorService>();
    }
}