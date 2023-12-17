using Grace.DependencyInjection;
using KeyerTest.ImageHandler;

namespace KeyerTest.Di;

public static class DiInitializer
{
    public static DependencyInjectionContainer Container { get; private set; }
    public static void DiInitialize()
    {
        Container = new DependencyInjectionContainer();

        Container.Configure(c =>
        {
            c.Export<FileImageProvider>().As<IImageProvider>();
            c.Export<FileLoader>().As<FileLoader>();
        });
        
        var imageProvider = Container.Locate<IImageProvider>();
        var fileLoader = Container.Locate<FileLoader>();
    }
}