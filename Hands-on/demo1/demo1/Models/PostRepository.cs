using demo1.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo1.Models
{
    public class PostRepository:IPostRepository

    {
        public List<PostViewModel>GetPosts()
        {
            var posts = new List<PostViewModel> { new PostViewModel()
            {
                PostId=101,Title="Devops",Description="Devops demo",author="Sasmithaa"

            } ,new PostViewModel()
             {
                PostId=102,Title="Devops1",Description="Devops demo1",author="Preethi"

            } ,new PostViewModel()
             {
                PostId=103,Title="Devops2",Description="Devops demo2",author="Sanjana"

            } ,
            };
            return posts;
        }
        
    }
}
