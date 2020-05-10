using System.Collections.Generic;
using ImageGallery.Model;

namespace ImageGallery.Client.ViewModels
{
    public class GalleryIndexViewModel
    {
        public GalleryIndexViewModel(IEnumerable<Image> images, string identityToken)
        {
            Images = images;
            IdentityToken = identityToken;
        }

        public string IdentityToken { get; }

        public IEnumerable<Image> Images { get; } = new List<Image>();
    }
}