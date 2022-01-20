using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo1.Models;
namespace demo1.Models.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
