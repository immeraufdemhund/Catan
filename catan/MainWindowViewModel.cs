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

        }
    }
}
