namespace Catan.Models
{
    public class ResourceTile
    {
        public ResourceType ResourceType { get; set; }
        public ResourceMarker Marker { get; set; }

        public ResourceTile(int number, ResourceType resourceType)
        {
            ResourceType = resourceType;
            Marker = new ResourceMarker(number);
        }
    }
}
