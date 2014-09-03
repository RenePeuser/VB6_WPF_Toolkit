using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace VB6_WPF_ToolKit_Interfaces
{
    public static class AssemblyLoader
    {
        //Assembly Loader der per MEF Assembly lädt.
        public static void LoadAssembly(string path, object compositionContainer)
        {
            //Erzeuge Assembly Catalog aus einem Verzeichnis
            using (var catalog = new DirectoryCatalog(path))
            {
                //Erzeuge Compositioncontainer mit dem zuvor erzeugten Katalog
                using (var container = new CompositionContainer(catalog))
                {                    
                    //Erzeuge Assembly Insstanz in den Zielcontainer
                    container.ComposeParts(compositionContainer);
                }
            }            
        }
    }
}