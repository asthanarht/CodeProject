using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPMobile.Models
{
    public interface ICPFeeds
    {
        Task Init();

        Task<IEnumerable<Item>> GetArticleAsync(int page);

        Task<CPFeed> GetForumAsync();

        Task<bool> GetAccessToken(string username, string password);
    }

}
