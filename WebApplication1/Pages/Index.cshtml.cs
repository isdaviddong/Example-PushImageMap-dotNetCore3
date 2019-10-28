using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            var ChannelAccessToken = "___換成你自己的token___";
            var UserId = "___換成你自己的UserID___";
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(ChannelAccessToken);
            var ImageMap = new isRock.LineBot.ImagemapMessage(
                    new Uri("https://i.imgur.com/FIhYHDm.jpg"), //圖片位置 
                    new Uri("https://www.google.com")); //URL位置
            bot.PushMessage(UserId, ImageMap);

        }
    }
}
