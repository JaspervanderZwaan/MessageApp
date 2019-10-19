using Data.Interfaces;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Models.Datamodels;

namespace MessApp.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository UserRepository;
        private readonly MessageRepository MessageRepository;

        public UserController(IUserContext ucontext, IMessageContext mcontext)
        {
            UserRepository = new UserRepository(ucontext);
            MessageRepository = new MessageRepository(mcontext);
        }

        public IActionResult Account(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                return View();
            }
            return View();
        }

        public IActionResult Authenticate(User user = null)
        {
            if (!string.IsNullOrEmpty(user.Username) && !string.IsNullOrEmpty(user.Password))
            {
                if (UserRepository.Authenticate(user))
                {
                    return View();
                }
            }
            return View();
        }

        public IActionResult Register(User user = null)
        {
            if (!string.IsNullOrEmpty(user.Username) && !string.IsNullOrEmpty(user.Password) && !string.IsNullOrEmpty(user.Email))
            {
                if (UserRepository.Insert(user))
                {
                    return View();
                }
            }
            return View();
        }
    }
}