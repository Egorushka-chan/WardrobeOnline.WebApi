using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeOnline.BLL.Repository.Interfaces
{
    public interface IImageProvider
    {
        public string GetImageLink(int imageID);
    }
}
