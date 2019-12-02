using AspNetCoreVideo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public interface IVideoData
    {
        public IEnumerable<Video> GetAll();
        public Video Get(int id);
        public void Add(Video newVideo);
    }
}
