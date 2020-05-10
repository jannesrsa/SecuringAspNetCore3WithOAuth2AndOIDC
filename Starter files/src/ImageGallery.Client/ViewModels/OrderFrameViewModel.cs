using ImageGallery.Model;

namespace ImageGallery.Client.ViewModels
{
    public class OrderFrameViewModel
    {
        public OrderFrameViewModel(Address address)
        {
            Address = address;
        }

        public Address Address { get; }
    }
}