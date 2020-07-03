using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DichVuGame.Data;
using DichVuGame.Models;
using DichVuGame.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DichVuGame.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class SpinwheelController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public SpinwheelViewModel SpinwheelVM { get; set; }
        public SpinwheelController(ApplicationDbContext db)
        {
            _db = db;
            SpinwheelVM = new SpinwheelViewModel()
            {
                Codes = new List<string>(),
                Discounts = new List<string>(),
                Coins = new List<string>()
            };
        }
        public IActionResult Index()
        {
            return View(SpinwheelVM);
        }
        public async Task<IActionResult> Reward()
        {
            List<String> Reward = new List<string>() { "Game", "Discount", "Coint" };
            var totalReward = Reward.Count();
            var rewardOffset = new Random().Next(0, totalReward);
            var randomReward = Reward.Skip(rewardOffset).FirstOrDefault();
            //var user = await _db.ApplicationUsers.Where(u => u.Email == User.Identity.Name).FirstOrDefaultAsync();
            switch (randomReward)
            {
                case "Game":  //Lấy random game 
                    var total = _db.Games.Count();
                    var offset = new Random().Next(0, total);
                    var game = _db.Games.Skip(offset).FirstOrDefault();
                    var code = _db.Codes.Where(u => u.GameID == game.ID).FirstOrDefault();
                    SpinwheelVM.Code = code;
                    //Order order = new Order()
                    //{
                    //    ApplicationUserID = user.Id,
                    //    PurchasedDate = DateTime.Now,
                    //    Total = 0
                    //};
                    //_db.Add(order);
                    //OrderDetail orderDetail = new OrderDetail()
                    //{
                    //    OrderID = order.ID,
                    //    CodeID = code.ID,
                    //};
                    //_db.Add(orderDetail);
                    //_db.SaveChanges();
                    break;
                case "Discount": //Lấy random mã giảm giá
                    var totalDiscount = _db.Discount.Count();
                    var offsetDiscount = new Random().Next(0, totalDiscount);
                    var discount = _db.Discount.Skip(offsetDiscount).FirstOrDefault();
                    SpinwheelVM.Discount = discount;
                    break;
                case "Coin": //Lấy random số coin 
                    var randomCoin = new Random().Next(10000, 30000);
                    SpinwheelVM.Coin = randomCoin;
                    //user.Balance += randomCoin;
                    //_db.SaveChanges();
                    break;
                default:
                    break;
            }
            return View(SpinwheelVM);
        }

    }
}
