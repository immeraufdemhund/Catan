using Catan.Models;
using System.Collections.ObjectModel;

namespace catan
{
    public class MainWindowViewModel
    {
        public ObservableCollection<ResourceTile> ResourceTiles { get; private set; }

        public MainWindowViewModel()
        {
            ResourceTiles = new ObservableCollection<ResourceTile>();
            //3,4,5,4,3
            for (int i = 0; i < 3 + 4 + 5 + 4 + 3; i++)
            {
                ResourceTiles.Add(new ResourceTile(((i + 2) % 12), (ResourceType)(i % 6)));
            }
        }
    }
}
