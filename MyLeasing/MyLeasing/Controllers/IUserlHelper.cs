using System.Threading.Tasks;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Controllers
{
    public interface IUserlHelper
    {
        Task AddUserAsync(User user, string password);
        Task AddUserAsync();
    }
}